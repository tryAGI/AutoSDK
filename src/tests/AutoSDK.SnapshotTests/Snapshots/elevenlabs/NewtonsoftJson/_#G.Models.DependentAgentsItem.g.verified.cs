//HintName: G.Models.DependentAgentsItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DependentAgentsItem : global::System.IEquatable<DependentAgentsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DependentAvailableAgentIdentifier? Available { get; init; }
#else
        public global::G.DependentAvailableAgentIdentifier? Available { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Available))]
#endif
        public bool IsAvailable => Available != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DependentAgentsItem(global::G.DependentAvailableAgentIdentifier value) => new DependentAgentsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DependentAvailableAgentIdentifier?(DependentAgentsItem @this) => @this.Available;

        /// <summary>
        /// 
        /// </summary>
        public DependentAgentsItem(global::G.DependentAvailableAgentIdentifier? value)
        {
            Available = value;
        }

        /// <summary>
        /// A model that represents an agent dependent on a knowledge base/tools<br/>
        /// to which the user has no direct access.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DependentUnknownAgentIdentifier? Unknown { get; init; }
#else
        public global::G.DependentUnknownAgentIdentifier? Unknown { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unknown))]
#endif
        public bool IsUnknown => Unknown != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DependentAgentsItem(global::G.DependentUnknownAgentIdentifier value) => new DependentAgentsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DependentUnknownAgentIdentifier?(DependentAgentsItem @this) => @this.Unknown;

        /// <summary>
        /// 
        /// </summary>
        public DependentAgentsItem(global::G.DependentUnknownAgentIdentifier? value)
        {
            Unknown = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DependentAgentsItem(
            global::G.GetKnowledgeBaseSummaryFileResponseModelDependentAgentDiscriminatorType? type,
            global::G.DependentAvailableAgentIdentifier? available,
            global::G.DependentUnknownAgentIdentifier? unknown
            )
        {
            Type = type;

            Available = available;
            Unknown = unknown;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Unknown as object ??
            Available as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAvailable && !IsUnknown || !IsAvailable && IsUnknown;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.DependentAvailableAgentIdentifier?, TResult>? available = null,
            global::System.Func<global::G.DependentUnknownAgentIdentifier?, TResult>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAvailable && available != null)
            {
                return available(Available!);
            }
            else if (IsUnknown && unknown != null)
            {
                return unknown(Unknown!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.DependentAvailableAgentIdentifier?>? available = null,
            global::System.Action<global::G.DependentUnknownAgentIdentifier?>? unknown = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAvailable)
            {
                available?.Invoke(Available!);
            }
            else if (IsUnknown)
            {
                unknown?.Invoke(Unknown!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Available,
                typeof(global::G.DependentAvailableAgentIdentifier),
                Unknown,
                typeof(global::G.DependentUnknownAgentIdentifier),
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
        public bool Equals(DependentAgentsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.DependentAvailableAgentIdentifier?>.Default.Equals(Available, other.Available) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DependentUnknownAgentIdentifier?>.Default.Equals(Unknown, other.Unknown) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DependentAgentsItem obj1, DependentAgentsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DependentAgentsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DependentAgentsItem obj1, DependentAgentsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DependentAgentsItem o && Equals(o);
        }
    }
}
