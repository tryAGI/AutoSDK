using Microsoft.OpenApi;

namespace AutoSDK.Extensions;

/// <summary>
/// Compares two schemas by what they describe, ignoring where they came from.
/// </summary>
/// <remarks>
/// A spec that repeats the same inline schema - the same error body on twenty operations, say -
/// gives the generator no way to tell the copies apart, so it emits a fresh type per occurrence and
/// numbers the names: <c>InvalidTokenErrorBody</c>, <c>InvalidTokenErrorBody11</c>,
/// <c>InvalidTokenErrorBody22</c>. Measured across the workspace on 2026-11-16, 4883 of 8870
/// numbered type names - 55% - are copies like this rather than distinct types.
///
/// Equality here is deliberately conservative: anything this comparer is not sure about is reported
/// as different. Collapsing two types that are not the same would silently change what a caller
/// deserializes, while failing to collapse two that are only leaves a number in a name.
/// </remarks>
public static class OpenApiSchemaStructuralComparer
{
    private const int MaxDepth = 12;

    /// <summary>
    /// True when the two schemas describe the same shape.
    /// </summary>
    public static bool AreStructurallyEqual(IOpenApiSchema? left, IOpenApiSchema? right)
    {
        return AreEqual(left, right, depth: 0);
    }

    private static bool AreEqual(IOpenApiSchema? left, IOpenApiSchema? right, int depth)
    {
        if (ReferenceEquals(left, right))
        {
            return true;
        }

        if (left is null || right is null)
        {
            return false;
        }

        // Deeper than this and the answer stops being cheap; report "different" rather than guess.
        if (depth > MaxDepth)
        {
            return false;
        }

        // A reference is the same schema only when it points at the same component. Resolving and
        // comparing the targets would make two different components with identical shapes look
        // interchangeable, which they are not: they are named separately on purpose.
        var leftReference = (left as OpenApiSchemaReference)?.Reference?.Id;
        var rightReference = (right as OpenApiSchemaReference)?.Reference?.Id;
        if (leftReference != null || rightReference != null)
        {
            return string.Equals(leftReference, rightReference, StringComparison.Ordinal);
        }

        // `Type` carries nullability in 3.1 (it can include `null`), so comparing it covers both.
        if (left.Type != right.Type ||
            !string.Equals(left.Format, right.Format, StringComparison.Ordinal) ||
            !string.Equals(left.Const, right.Const, StringComparison.Ordinal) ||
            left.AdditionalPropertiesAllowed != right.AdditionalPropertiesAllowed)
        {
            return false;
        }

        if (!SetsAreEqual(left.Required, right.Required))
        {
            return false;
        }

        if (!EnumsAreEqual(left.Enum, right.Enum))
        {
            return false;
        }

        if (!DiscriminatorsAreEqual(left.Discriminator, right.Discriminator))
        {
            return false;
        }

        if (!AreEqual(left.Items, right.Items, depth + 1) ||
            !AreEqual(left.AdditionalProperties, right.AdditionalProperties, depth + 1))
        {
            return false;
        }

        return PropertiesAreEqual(left.Properties, right.Properties, depth) &&
               ListsAreEqual(left.OneOf, right.OneOf, depth) &&
               ListsAreEqual(left.AnyOf, right.AnyOf, depth) &&
               ListsAreEqual(left.AllOf, right.AllOf, depth);
    }

    private static bool PropertiesAreEqual(
        IDictionary<string, IOpenApiSchema>? left,
        IDictionary<string, IOpenApiSchema>? right,
        int depth)
    {
        var leftCount = left?.Count ?? 0;
        var rightCount = right?.Count ?? 0;
        if (leftCount != rightCount)
        {
            return false;
        }

        if (leftCount == 0)
        {
            return true;
        }

        foreach (var entry in left!)
        {
            if (!right!.TryGetValue(entry.Key, out var other) ||
                !AreEqual(entry.Value, other, depth + 1))
            {
                return false;
            }
        }

        return true;
    }

    private static bool ListsAreEqual(
        IList<IOpenApiSchema>? left,
        IList<IOpenApiSchema>? right,
        int depth)
    {
        var leftCount = left?.Count ?? 0;
        var rightCount = right?.Count ?? 0;
        if (leftCount != rightCount)
        {
            return false;
        }

        for (var i = 0; i < leftCount; i++)
        {
            // Order matters: a union's variants are generated in order, so two differently ordered
            // unions produce different code even when the sets match.
            if (!AreEqual(left![i], right![i], depth + 1))
            {
                return false;
            }
        }

        return true;
    }

    private static bool SetsAreEqual(ISet<string>? left, ISet<string>? right)
    {
        var leftCount = left?.Count ?? 0;
        var rightCount = right?.Count ?? 0;
        if (leftCount != rightCount)
        {
            return false;
        }

        if (leftCount == 0)
        {
            return true;
        }

        foreach (var value in left!)
        {
            if (!right!.Contains(value))
            {
                return false;
            }
        }

        return true;
    }

    private static bool EnumsAreEqual(
        IList<System.Text.Json.Nodes.JsonNode>? left,
        IList<System.Text.Json.Nodes.JsonNode>? right)
    {
        var leftCount = left?.Count ?? 0;
        var rightCount = right?.Count ?? 0;
        if (leftCount != rightCount)
        {
            return false;
        }

        for (var i = 0; i < leftCount; i++)
        {
            // Members are generated in declaration order, so order is part of the shape.
            if (!string.Equals(
                    left![i]?.ToJsonString(),
                    right![i]?.ToJsonString(),
                    StringComparison.Ordinal))
            {
                return false;
            }
        }

        return true;
    }

    private static bool DiscriminatorsAreEqual(OpenApiDiscriminator? left, OpenApiDiscriminator? right)
    {
        if (left is null || right is null)
        {
            return left is null && right is null;
        }

        if (!string.Equals(left.PropertyName, right.PropertyName, StringComparison.Ordinal))
        {
            return false;
        }

        var leftCount = left.Mapping?.Count ?? 0;
        var rightCount = right.Mapping?.Count ?? 0;
        if (leftCount != rightCount)
        {
            return false;
        }

        if (leftCount == 0)
        {
            return true;
        }

        foreach (var entry in left.Mapping!)
        {
            if (!right.Mapping!.TryGetValue(entry.Key, out var other) ||
                !string.Equals(entry.Value.Reference?.Id, other.Reference?.Id, StringComparison.Ordinal))
            {
                return false;
            }
        }

        return true;
    }
}
