using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.Generation;

internal static class AuthorizationHelpers
{
    internal readonly struct AuthorizationRequirementData
    {
        internal AuthorizationRequirementData(
            EquatableArray<AuthorizationRequirementSet> requirementSets,
            EquatableArray<Authorization> authorizations)
        {
            RequirementSets = requirementSets;
            Authorizations = authorizations;
        }

        internal EquatableArray<AuthorizationRequirementSet> RequirementSets { get; }
        internal EquatableArray<Authorization> Authorizations { get; }
    }

    internal sealed class RequirementSetCache
    {
        private readonly Dictionary<IList<OpenApiSecurityRequirement>, AuthorizationRequirementData> _values =
            new(SecurityRequirementListReferenceComparer.Instance);

        internal AuthorizationRequirementData GetOrCreate(OperationContext operation)
        {
            operation = operation ?? throw new ArgumentNullException(nameof(operation));

            var requirements = GetEffectiveSecurityRequirements(operation);
            if (_values.TryGetValue(requirements, out var cached))
            {
                return cached;
            }

            var created = CreateRequirementData(operation, requirements);
            _values.Add(requirements, created);
            return created;
        }
    }

    private sealed class SecurityRequirementListReferenceComparer : IEqualityComparer<IList<OpenApiSecurityRequirement>>
    {
        internal static SecurityRequirementListReferenceComparer Instance { get; } = new();

        public bool Equals(
            IList<OpenApiSecurityRequirement>? x,
            IList<OpenApiSecurityRequirement>? y)
        {
            return ReferenceEquals(x, y);
        }

        public int GetHashCode(IList<OpenApiSecurityRequirement> obj)
        {
            return RuntimeHelpers.GetHashCode(obj);
        }
    }

    internal static IList<OpenApiSecurityRequirement> GetEffectiveSecurityRequirements(
        OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        return operation.Operation.Security ?? operation.GlobalSecurityRequirements;
    }

    internal static ImmutableArray<AuthorizationRequirementSet> CreateRequirementSets(
        OperationContext operation)
    {
        operation = operation ?? throw new ArgumentNullException(nameof(operation));

        return CreateRequirementData(operation, GetEffectiveSecurityRequirements(operation))
            .RequirementSets
            .AsImmutableArray();
    }

    private static AuthorizationRequirementData CreateRequirementData(
        OperationContext operation,
        IList<OpenApiSecurityRequirement> requirements)
    {
        var requirementSets = ImmutableArray.CreateBuilder<AuthorizationRequirementSet>(requirements.Count);
        var distinctAuthorizations = ImmutableArray.CreateBuilder<Authorization>();
        var seenIdentities = new HashSet<string>(StringComparer.Ordinal);

        foreach (var requirement in requirements)
        {
            var requirementAuthorizations = ImmutableArray.CreateBuilder<Authorization>(requirement.Count);
            IEnumerable<KeyValuePair<OpenApiSecuritySchemeReference, List<string>>> orderedSchemes = requirement.Count <= 1
                ? requirement
                : requirement.OrderBy(static x => GetSecurityRequirementSortKey(x.Key), StringComparer.Ordinal);

            foreach (var pair in orderedSchemes)
            {
                var authorization = CSharpAuthorizationFactory.FromOpenApiSecurityScheme(
                    pair.Key,
                    operation.Settings,
                    operation.GlobalSettings);
                requirementAuthorizations.Add(authorization);
                if (seenIdentities.Add(GetIdentity(authorization)))
                {
                    distinctAuthorizations.Add(authorization);
                }
            }

            requirementSets.Add(new AuthorizationRequirementSet(
                requirementAuthorizations.MoveToImmutable().AsEquatableArray()));
        }

        return new AuthorizationRequirementData(
            requirementSets.MoveToImmutable().AsEquatableArray(),
            distinctAuthorizations.ToImmutable().AsEquatableArray());
    }

    internal static string GetIdentity(Authorization authorization)
    {
        return authorization.Type switch
        {
            SecuritySchemeType.ApiKey => $"{authorization.Type:G}|{authorization.In:G}|{authorization.Name}",
            SecuritySchemeType.OAuth2 => $"{authorization.Type:G}|{authorization.SchemeId}",
            SecuritySchemeType.OpenIdConnect => $"{authorization.Type:G}|{authorization.SchemeId}",
            SecuritySchemeType.MutualTLS => $"{authorization.Type:G}|{authorization.SchemeId}",
            SecuritySchemeType.Http => $"{authorization.Type:G}|{authorization.Scheme.ToUpperInvariant()}",
            _ => $"{authorization.Type:G}|{authorization.In:G}|{authorization.Name}|{authorization.SchemeId}",
        };
    }

    internal static IReadOnlyDictionary<string, Authorization> CreateResolvedAuthorizationMap(
        IEnumerable<Authorization> authorizations)
    {
        authorizations = authorizations ?? throw new ArgumentNullException(nameof(authorizations));

        var distinct = new List<Authorization>();
        var seenIdentities = new HashSet<string>(StringComparer.Ordinal);

        foreach (var authorization in authorizations)
        {
            var identity = GetIdentity(authorization);
            if (seenIdentities.Add(identity))
            {
                distinct.Add(authorization);
            }
        }

        var collisionCounts = distinct
            .GroupBy(static x => x.FriendlyName, StringComparer.Ordinal)
            .ToDictionary(static x => x.Key, static x => x.Count(), StringComparer.Ordinal);
        var usedNames = new HashSet<string>(StringComparer.Ordinal);
        var map = new Dictionary<string, Authorization>(StringComparer.Ordinal);

        foreach (var authorization in distinct)
        {
            var friendlyName = authorization.FriendlyName;
            if (collisionCounts[friendlyName] > 1 || !usedNames.Add(friendlyName))
            {
                friendlyName = GetUniqueFriendlyName(authorization, usedNames);
            }

            var resolved = friendlyName == authorization.FriendlyName
                ? authorization
                : authorization with
                {
                    FriendlyName = friendlyName,
                    MethodName = $"AuthorizeUsing{friendlyName}",
                };

            map[GetIdentity(authorization)] = resolved;
        }

        return map;
    }

    internal static EndPoint NormalizeEndPoint(
        EndPoint endPoint,
        IReadOnlyDictionary<string, Authorization> authorizationsByIdentity)
    {
        authorizationsByIdentity = authorizationsByIdentity ?? throw new ArgumentNullException(nameof(authorizationsByIdentity));

        return endPoint with
        {
            Authorizations = NormalizeAuthorizations(endPoint.Authorizations, authorizationsByIdentity),
            AuthorizationRequirements = NormalizeRequirementSets(endPoint.AuthorizationRequirements, authorizationsByIdentity),
        };
    }

    private static EquatableArray<Authorization> NormalizeAuthorizations(
        EquatableArray<Authorization> authorizations,
        IReadOnlyDictionary<string, Authorization> authorizationsByIdentity)
    {
        var normalized = new List<Authorization>(authorizations.Length);
        var seenIdentities = new HashSet<string>(StringComparer.Ordinal);

        for (var i = 0; i < authorizations.Length; i++)
        {
            var identity = GetIdentity(authorizations[i]);
            if (!seenIdentities.Add(identity) ||
                !authorizationsByIdentity.TryGetValue(identity, out var resolved))
            {
                continue;
            }

            normalized.Add(resolved);
        }

        return normalized.ToImmutableArray().AsEquatableArray();
    }

    private static EquatableArray<AuthorizationRequirementSet> NormalizeRequirementSets(
        EquatableArray<AuthorizationRequirementSet> requirementSets,
        IReadOnlyDictionary<string, Authorization> authorizationsByIdentity)
    {
        if (requirementSets.IsEmpty)
        {
            return requirementSets;
        }

        var normalized = new AuthorizationRequirementSet[requirementSets.Length];
        for (var i = 0; i < requirementSets.Length; i++)
        {
            normalized[i] = requirementSets[i] with
            {
                Authorizations = NormalizeAuthorizations(requirementSets[i].Authorizations, authorizationsByIdentity),
            };
        }

        return normalized.ToImmutableArray().AsEquatableArray();
    }

    private static string GetUniqueFriendlyName(
        Authorization authorization,
        HashSet<string> usedNames)
    {
        var settings = (CSharpSettings)authorization.Settings;
        var candidates = new[]
        {
            CSharpAuthorizationFactory.NormalizeFriendlyName(authorization.SchemeId, settings),
            CSharpAuthorizationFactory.NormalizeFriendlyName($"{authorization.FriendlyName}{authorization.SchemeId}", settings),
        };

        foreach (var candidate in candidates)
        {
            if (!string.IsNullOrWhiteSpace(candidate) && usedNames.Add(candidate))
            {
                return candidate;
            }
        }

        for (var i = 2; ; i++)
        {
            var candidate = CSharpAuthorizationFactory.NormalizeFriendlyName(
                $"{authorization.FriendlyName}{i}",
                settings);
            if (usedNames.Add(candidate))
            {
                return candidate;
            }
        }
    }

    private static string GetSecurityRequirementSortKey(OpenApiSecuritySchemeReference scheme)
    {
        return scheme.Type switch
        {
            SecuritySchemeType.ApiKey => $"{scheme.Type:G}|{scheme.In:G}|{scheme.Name}",
            SecuritySchemeType.OAuth2 => $"{scheme.Type:G}|{scheme.Reference?.Id ?? scheme.Name}",
            SecuritySchemeType.OpenIdConnect => $"{scheme.Type:G}|{scheme.Reference?.Id ?? scheme.Name}",
            SecuritySchemeType.MutualTLS => $"{scheme.Type:G}|{scheme.Reference?.Id ?? scheme.Name}",
            SecuritySchemeType.Http => $"{scheme.Type:G}|{scheme.Scheme?.ToUpperInvariant()}",
            _ => $"{scheme.Type:G}|{scheme.Reference?.Id ?? scheme.Name ?? scheme.Scheme}",
        };
    }
}
