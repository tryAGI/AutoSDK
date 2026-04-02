//HintName: G.Models.BridgeTransferNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BridgeTransferNode : global::System.IEquatable<BridgeTransferNode>
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
        public global::G.BridgeTransferNodeVariant2? BridgeTransferNodeVariant2 { get; init; }
#else
        public global::G.BridgeTransferNodeVariant2? BridgeTransferNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BridgeTransferNodeVariant2))]
#endif
        public bool IsBridgeTransferNodeVariant2 => BridgeTransferNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BridgeTransferNode(global::G.NodeBase value) => new BridgeTransferNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(BridgeTransferNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public BridgeTransferNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BridgeTransferNode(global::G.BridgeTransferNodeVariant2 value) => new BridgeTransferNode((global::G.BridgeTransferNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BridgeTransferNodeVariant2?(BridgeTransferNode @this) => @this.BridgeTransferNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public BridgeTransferNode(global::G.BridgeTransferNodeVariant2? value)
        {
            BridgeTransferNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BridgeTransferNode(
            global::G.NodeBase? @base,
            global::G.BridgeTransferNodeVariant2? bridgeTransferNodeVariant2
            )
        {
            Base = @base;
            BridgeTransferNodeVariant2 = bridgeTransferNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            BridgeTransferNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            BridgeTransferNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsBridgeTransferNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.BridgeTransferNodeVariant2?, TResult>? bridgeTransferNodeVariant2 = null,
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
            else if (IsBridgeTransferNodeVariant2 && bridgeTransferNodeVariant2 != null)
            {
                return bridgeTransferNodeVariant2(BridgeTransferNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.BridgeTransferNodeVariant2?>? bridgeTransferNodeVariant2 = null,
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
            else if (IsBridgeTransferNodeVariant2)
            {
                bridgeTransferNodeVariant2?.Invoke(BridgeTransferNodeVariant2!);
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
                BridgeTransferNodeVariant2,
                typeof(global::G.BridgeTransferNodeVariant2),
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
        public bool Equals(BridgeTransferNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BridgeTransferNodeVariant2?>.Default.Equals(BridgeTransferNodeVariant2, other.BridgeTransferNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BridgeTransferNode obj1, BridgeTransferNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BridgeTransferNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BridgeTransferNode obj1, BridgeTransferNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BridgeTransferNode o && Equals(o);
        }
    }
}
