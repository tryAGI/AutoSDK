//HintName: G.Models.EndNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EndNode : global::System.IEquatable<EndNode>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NodeBase? Base { get; init; }
#else
        public global::G.NodeBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.EndNodeVariant2? EndNodeVariant2 { get; init; }
#else
        public global::G.EndNodeVariant2? EndNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EndNodeVariant2))]
#endif
        public bool IsEndNodeVariant2 => EndNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndNode(global::G.NodeBase value) => new EndNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(EndNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public EndNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EndNode(global::G.EndNodeVariant2 value) => new EndNode((global::G.EndNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EndNodeVariant2?(EndNode @this) => @this.EndNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public EndNode(global::G.EndNodeVariant2? value)
        {
            EndNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EndNode(
            global::G.NodeBase? @base,
            global::G.EndNodeVariant2? endNodeVariant2
            )
        {
            Base = @base;
            EndNodeVariant2 = endNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EndNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            EndNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsEndNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.EndNodeVariant2?, TResult>? endNodeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsEndNodeVariant2 && endNodeVariant2 != null)
            {
                return endNodeVariant2(EndNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.EndNodeVariant2?>? endNodeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsEndNodeVariant2)
            {
                endNodeVariant2?.Invoke(EndNodeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::G.NodeBase),
                EndNodeVariant2,
                typeof(global::G.EndNodeVariant2),
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
        public bool Equals(EndNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EndNodeVariant2?>.Default.Equals(EndNodeVariant2, other.EndNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EndNode obj1, EndNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EndNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EndNode obj1, EndNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EndNode o && Equals(o);
        }
    }
}
