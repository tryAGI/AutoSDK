//HintName: G.Models.BranchNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BranchNode : global::System.IEquatable<BranchNode>
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
        public global::G.BranchNodeVariant2? BranchNodeVariant2 { get; init; }
#else
        public global::G.BranchNodeVariant2? BranchNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BranchNodeVariant2))]
#endif
        public bool IsBranchNodeVariant2 => BranchNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchNode(global::G.NodeBase value) => new BranchNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(BranchNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public BranchNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BranchNode(global::G.BranchNodeVariant2 value) => new BranchNode((global::G.BranchNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BranchNodeVariant2?(BranchNode @this) => @this.BranchNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public BranchNode(global::G.BranchNodeVariant2? value)
        {
            BranchNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BranchNode(
            global::G.NodeBase? @base,
            global::G.BranchNodeVariant2? branchNodeVariant2
            )
        {
            Base = @base;
            BranchNodeVariant2 = branchNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BranchNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            BranchNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsBranchNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.BranchNodeVariant2?, TResult>? branchNodeVariant2 = null,
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
            else if (IsBranchNodeVariant2 && branchNodeVariant2 != null)
            {
                return branchNodeVariant2(BranchNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.BranchNodeVariant2?>? branchNodeVariant2 = null,
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
            else if (IsBranchNodeVariant2)
            {
                branchNodeVariant2?.Invoke(BranchNodeVariant2!);
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
                BranchNodeVariant2,
                typeof(global::G.BranchNodeVariant2),
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
        public bool Equals(BranchNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BranchNodeVariant2?>.Default.Equals(BranchNodeVariant2, other.BranchNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BranchNode obj1, BranchNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BranchNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BranchNode obj1, BranchNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BranchNode o && Equals(o);
        }
    }
}
