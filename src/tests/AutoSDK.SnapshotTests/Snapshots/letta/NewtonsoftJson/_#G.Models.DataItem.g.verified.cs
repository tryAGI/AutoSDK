//HintName: G.Models.DataItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem : global::System.IEquatable<DataItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1? Agent { get; init; }
#else
        public global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1? Agent { get; }
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
        public static implicit operator DataItem(global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1 value) => new DataItem((global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1?(DataItem @this) => @this.Agent;

        /// <summary>
        /// 
        /// </summary>
        public DataItem(global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1? value)
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
            global::System.Func<global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1?, TResult>? agent = null,
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
            global::System.Action<global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1?>? agent = null,
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
                typeof(global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1),
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
        public bool Equals(DataItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ClientSideAccessTokensCreateClientSideAccessTokenResponsePolicyDataItemVariant1?>.Default.Equals(Agent, other.Agent) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem obj1, DataItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem obj1, DataItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem o && Equals(o);
        }
    }
}
