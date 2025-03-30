//HintName: G.Models.AgentToolsItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AgentToolsItem : global::System.IEquatable<AgentToolsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ConvAIStoredSecretDependenciesAgentToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DependentAvailableAgentToolIdentifier? Available { get; init; }
#else
        public global::G.DependentAvailableAgentToolIdentifier? Available { get; }
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
        public static implicit operator AgentToolsItem(global::G.DependentAvailableAgentToolIdentifier value) => new AgentToolsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DependentAvailableAgentToolIdentifier?(AgentToolsItem @this) => @this.Available;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolsItem(global::G.DependentAvailableAgentToolIdentifier? value)
        {
            Available = value;
        }

        /// <summary>
        /// A model that represents an tool dependent on a knowledge base/tools<br/>
        /// to which the user has no direct access.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DependentUnknownAgentToolIdentifier? Unknown { get; init; }
#else
        public global::G.DependentUnknownAgentToolIdentifier? Unknown { get; }
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
        public static implicit operator AgentToolsItem(global::G.DependentUnknownAgentToolIdentifier value) => new AgentToolsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DependentUnknownAgentToolIdentifier?(AgentToolsItem @this) => @this.Unknown;

        /// <summary>
        /// 
        /// </summary>
        public AgentToolsItem(global::G.DependentUnknownAgentToolIdentifier? value)
        {
            Unknown = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AgentToolsItem(
            global::G.ConvAIStoredSecretDependenciesAgentToolDiscriminatorType? type,
            global::G.DependentAvailableAgentToolIdentifier? available,
            global::G.DependentUnknownAgentToolIdentifier? unknown
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
            global::System.Func<global::G.DependentAvailableAgentToolIdentifier?, TResult>? available = null,
            global::System.Func<global::G.DependentUnknownAgentToolIdentifier?, TResult>? unknown = null,
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
            global::System.Action<global::G.DependentAvailableAgentToolIdentifier?>? available = null,
            global::System.Action<global::G.DependentUnknownAgentToolIdentifier?>? unknown = null,
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
                typeof(global::G.DependentAvailableAgentToolIdentifier),
                Unknown,
                typeof(global::G.DependentUnknownAgentToolIdentifier),
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
        public bool Equals(AgentToolsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.DependentAvailableAgentToolIdentifier?>.Default.Equals(Available, other.Available) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DependentUnknownAgentToolIdentifier?>.Default.Equals(Unknown, other.Unknown) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AgentToolsItem obj1, AgentToolsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentToolsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AgentToolsItem obj1, AgentToolsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentToolsItem o && Equals(o);
        }
    }
}
