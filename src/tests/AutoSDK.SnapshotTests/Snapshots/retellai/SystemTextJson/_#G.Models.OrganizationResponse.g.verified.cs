//HintName: G.Models.OrganizationResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OrganizationResponse : global::System.IEquatable<OrganizationResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.Organization? Organization { get; init; }
#else
        public global::G.Organization? Organization { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Organization))]
#endif
        public bool IsOrganization => Organization != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OrganizationResponseVariant2? OrganizationResponseVariant2 { get; init; }
#else
        public global::G.OrganizationResponseVariant2? OrganizationResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrganizationResponseVariant2))]
#endif
        public bool IsOrganizationResponseVariant2 => OrganizationResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrganizationResponse(global::G.Organization value) => new OrganizationResponse((global::G.Organization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.Organization?(OrganizationResponse @this) => @this.Organization;

        /// <summary>
        /// 
        /// </summary>
        public OrganizationResponse(global::G.Organization? value)
        {
            Organization = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrganizationResponse(global::G.OrganizationResponseVariant2 value) => new OrganizationResponse((global::G.OrganizationResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OrganizationResponseVariant2?(OrganizationResponse @this) => @this.OrganizationResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public OrganizationResponse(global::G.OrganizationResponseVariant2? value)
        {
            OrganizationResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationResponse(
            global::G.Organization? organization,
            global::G.OrganizationResponseVariant2? organizationResponseVariant2
            )
        {
            Organization = organization;
            OrganizationResponseVariant2 = organizationResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OrganizationResponseVariant2 as object ??
            Organization as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Organization?.ToString() ??
            OrganizationResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOrganization && IsOrganizationResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.Organization?, TResult>? organization = null,
            global::System.Func<global::G.OrganizationResponseVariant2?, TResult>? organizationResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganization && organization != null)
            {
                return organization(Organization!);
            }
            else if (IsOrganizationResponseVariant2 && organizationResponseVariant2 != null)
            {
                return organizationResponseVariant2(OrganizationResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.Organization?>? organization = null,
            global::System.Action<global::G.OrganizationResponseVariant2?>? organizationResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrganization)
            {
                organization?.Invoke(Organization!);
            }
            else if (IsOrganizationResponseVariant2)
            {
                organizationResponseVariant2?.Invoke(OrganizationResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Organization,
                typeof(global::G.Organization),
                OrganizationResponseVariant2,
                typeof(global::G.OrganizationResponseVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(OrganizationResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.Organization?>.Default.Equals(Organization, other.Organization) &&
                global::System.Collections.Generic.EqualityComparer<global::G.OrganizationResponseVariant2?>.Default.Equals(OrganizationResponseVariant2, other.OrganizationResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrganizationResponse obj1, OrganizationResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrganizationResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrganizationResponse obj1, OrganizationResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrganizationResponse o && Equals(o);
        }
    }
}
