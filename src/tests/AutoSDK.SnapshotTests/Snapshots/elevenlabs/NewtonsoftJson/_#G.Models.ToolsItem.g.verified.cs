//HintName: G.Models.ToolsItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem : global::System.IEquatable<ToolsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ConvAIStoredSecretDependenciesToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DependentAvailableToolIdentifier? Available { get; init; }
#else
        public global::G.DependentAvailableToolIdentifier? Available { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Available))]
#endif
        public bool IsAvailable => Available != null;

        /// <summary>
        /// A model that represents an tool dependent on a knowledge base/tools<br/>
        /// to which the user has no direct access.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.DependentUnknownToolIdentifier? Unknown { get; init; }
#else
        public global::G.DependentUnknownToolIdentifier? Unknown { get; }
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
        public static implicit operator ToolsItem(global::G.DependentAvailableToolIdentifier value) => new ToolsItem((global::G.DependentAvailableToolIdentifier?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DependentAvailableToolIdentifier?(ToolsItem @this) => @this.Available;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::G.DependentAvailableToolIdentifier? value)
        {
            Available = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::G.DependentUnknownToolIdentifier value) => new ToolsItem((global::G.DependentUnknownToolIdentifier?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.DependentUnknownToolIdentifier?(ToolsItem @this) => @this.Unknown;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::G.DependentUnknownToolIdentifier? value)
        {
            Unknown = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(
            global::G.ConvAIStoredSecretDependenciesToolDiscriminatorType? type,
            global::G.DependentAvailableToolIdentifier? available,
            global::G.DependentUnknownToolIdentifier? unknown
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
        public override string? ToString() =>
            Available?.ToString() ??
            Unknown?.ToString() 
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
            global::System.Func<global::G.DependentAvailableToolIdentifier?, TResult>? available = null,
            global::System.Func<global::G.DependentUnknownToolIdentifier?, TResult>? unknown = null,
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
            global::System.Action<global::G.DependentAvailableToolIdentifier?>? available = null,
            global::System.Action<global::G.DependentUnknownToolIdentifier?>? unknown = null,
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
                typeof(global::G.DependentAvailableToolIdentifier),
                Unknown,
                typeof(global::G.DependentUnknownToolIdentifier),
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
        public bool Equals(ToolsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.DependentAvailableToolIdentifier?>.Default.Equals(Available, other.Available) &&
                global::System.Collections.Generic.EqualityComparer<global::G.DependentUnknownToolIdentifier?>.Default.Equals(Unknown, other.Unknown) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem obj1, ToolsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem obj1, ToolsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem o && Equals(o);
        }
    }
}
