//HintName: G.Models.TransferCallNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransferCallNode : global::System.IEquatable<TransferCallNode>
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
        public global::G.TransferCallNodeVariant2? TransferCallNodeVariant2 { get; init; }
#else
        public global::G.TransferCallNodeVariant2? TransferCallNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TransferCallNodeVariant2))]
#endif
        public bool IsTransferCallNodeVariant2 => TransferCallNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferCallNode(global::G.NodeBase value) => new TransferCallNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(TransferCallNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public TransferCallNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferCallNode(global::G.TransferCallNodeVariant2 value) => new TransferCallNode((global::G.TransferCallNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TransferCallNodeVariant2?(TransferCallNode @this) => @this.TransferCallNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TransferCallNode(global::G.TransferCallNodeVariant2? value)
        {
            TransferCallNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TransferCallNode(
            global::G.NodeBase? @base,
            global::G.TransferCallNodeVariant2? transferCallNodeVariant2
            )
        {
            Base = @base;
            TransferCallNodeVariant2 = transferCallNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TransferCallNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            TransferCallNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsTransferCallNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.TransferCallNodeVariant2?, TResult>? transferCallNodeVariant2 = null,
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
            else if (IsTransferCallNodeVariant2 && transferCallNodeVariant2 != null)
            {
                return transferCallNodeVariant2(TransferCallNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.TransferCallNodeVariant2?>? transferCallNodeVariant2 = null,
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
            else if (IsTransferCallNodeVariant2)
            {
                transferCallNodeVariant2?.Invoke(TransferCallNodeVariant2!);
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
                TransferCallNodeVariant2,
                typeof(global::G.TransferCallNodeVariant2),
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
        public bool Equals(TransferCallNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TransferCallNodeVariant2?>.Default.Equals(TransferCallNodeVariant2, other.TransferCallNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransferCallNode obj1, TransferCallNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransferCallNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransferCallNode obj1, TransferCallNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransferCallNode o && Equals(o);
        }
    }
}
