//HintName: G.Models.PolicyItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PolicyItem : global::System.IEquatable<PolicyItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1? Agent { get; init; }
#else
        public global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1? Agent { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Agent))]
#endif
        public bool IsAgent => Agent != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PolicyItem(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1 value) => new PolicyItem((global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1?(PolicyItem @this) => @this.Agent;

        /// <summary>
        /// 
        /// </summary>
        public PolicyItem(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1? value)
        {
            Agent = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Agent as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Agent?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAgent;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1?, TResult>? agent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent && agent != null)
            {
                return agent(Agent!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1?>? agent = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAgent)
            {
                agent?.Invoke(Agent!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Agent,
                typeof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1),
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
        public bool Equals(PolicyItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ClientSideAccessTokensCreateClientSideAccessTokenRequestPolicyItemVariant1?>.Default.Equals(Agent, other.Agent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PolicyItem obj1, PolicyItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PolicyItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PolicyItem obj1, PolicyItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PolicyItem o && Equals(o);
        }
    }
}
