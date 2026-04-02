//HintName: G.Models.MCPNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MCPNode : global::System.IEquatable<MCPNode>
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
        public global::G.MCPNodeVariant2? MCPNodeVariant2 { get; init; }
#else
        public global::G.MCPNodeVariant2? MCPNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPNodeVariant2))]
#endif
        public bool IsMCPNodeVariant2 => MCPNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MCPNode(global::G.NodeBase value) => new MCPNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(MCPNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public MCPNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MCPNode(global::G.MCPNodeVariant2 value) => new MCPNode((global::G.MCPNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MCPNodeVariant2?(MCPNode @this) => @this.MCPNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MCPNode(global::G.MCPNodeVariant2? value)
        {
            MCPNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MCPNode(
            global::G.NodeBase? @base,
            global::G.MCPNodeVariant2? mCPNodeVariant2
            )
        {
            Base = @base;
            MCPNodeVariant2 = mCPNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MCPNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            MCPNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsMCPNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.MCPNodeVariant2?, TResult>? mCPNodeVariant2 = null,
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
            else if (IsMCPNodeVariant2 && mCPNodeVariant2 != null)
            {
                return mCPNodeVariant2(MCPNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.MCPNodeVariant2?>? mCPNodeVariant2 = null,
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
            else if (IsMCPNodeVariant2)
            {
                mCPNodeVariant2?.Invoke(MCPNodeVariant2!);
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
                MCPNodeVariant2,
                typeof(global::G.MCPNodeVariant2),
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
        public bool Equals(MCPNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MCPNodeVariant2?>.Default.Equals(MCPNodeVariant2, other.MCPNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MCPNode obj1, MCPNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MCPNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MCPNode obj1, MCPNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MCPNode o && Equals(o);
        }
    }
}
