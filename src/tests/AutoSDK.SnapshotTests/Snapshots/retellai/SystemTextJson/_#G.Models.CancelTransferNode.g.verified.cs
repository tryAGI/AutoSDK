//HintName: G.Models.CancelTransferNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CancelTransferNode : global::System.IEquatable<CancelTransferNode>
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
        public global::G.CancelTransferNodeVariant2? CancelTransferNodeVariant2 { get; init; }
#else
        public global::G.CancelTransferNodeVariant2? CancelTransferNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CancelTransferNodeVariant2))]
#endif
        public bool IsCancelTransferNodeVariant2 => CancelTransferNodeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CancelTransferNode(global::G.NodeBase value) => new CancelTransferNode((global::G.NodeBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeBase?(CancelTransferNode @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CancelTransferNode(global::G.NodeBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CancelTransferNode(global::G.CancelTransferNodeVariant2 value) => new CancelTransferNode((global::G.CancelTransferNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CancelTransferNodeVariant2?(CancelTransferNode @this) => @this.CancelTransferNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CancelTransferNode(global::G.CancelTransferNodeVariant2? value)
        {
            CancelTransferNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CancelTransferNode(
            global::G.NodeBase? @base,
            global::G.CancelTransferNodeVariant2? cancelTransferNodeVariant2
            )
        {
            Base = @base;
            CancelTransferNodeVariant2 = cancelTransferNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CancelTransferNodeVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CancelTransferNodeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCancelTransferNodeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeBase?, TResult>? @base = null,
            global::System.Func<global::G.CancelTransferNodeVariant2?, TResult>? cancelTransferNodeVariant2 = null,
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
            else if (IsCancelTransferNodeVariant2 && cancelTransferNodeVariant2 != null)
            {
                return cancelTransferNodeVariant2(CancelTransferNodeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeBase?>? @base = null,
            global::System.Action<global::G.CancelTransferNodeVariant2?>? cancelTransferNodeVariant2 = null,
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
            else if (IsCancelTransferNodeVariant2)
            {
                cancelTransferNodeVariant2?.Invoke(CancelTransferNodeVariant2!);
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
                CancelTransferNodeVariant2,
                typeof(global::G.CancelTransferNodeVariant2),
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
        public bool Equals(CancelTransferNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::G.CancelTransferNodeVariant2?>.Default.Equals(CancelTransferNodeVariant2, other.CancelTransferNodeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CancelTransferNode obj1, CancelTransferNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CancelTransferNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CancelTransferNode obj1, CancelTransferNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CancelTransferNode o && Equals(o);
        }
    }
}
