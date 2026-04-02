//HintName: G.Models.SmsSuccessEdge.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SmsSuccessEdge : global::System.IEquatable<SmsSuccessEdge>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.NodeEdge? Node { get; init; }
#else
        public global::G.NodeEdge? Node { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Node))]
#endif
        public bool IsNode => Node != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.SmsSuccessEdgeVariant2? SmsSuccessEdgeVariant2 { get; init; }
#else
        public global::G.SmsSuccessEdgeVariant2? SmsSuccessEdgeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmsSuccessEdgeVariant2))]
#endif
        public bool IsSmsSuccessEdgeVariant2 => SmsSuccessEdgeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsSuccessEdge(global::G.NodeEdge value) => new SmsSuccessEdge((global::G.NodeEdge?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeEdge?(SmsSuccessEdge @this) => @this.Node;

        /// <summary>
        /// 
        /// </summary>
        public SmsSuccessEdge(global::G.NodeEdge? value)
        {
            Node = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsSuccessEdge(global::G.SmsSuccessEdgeVariant2 value) => new SmsSuccessEdge((global::G.SmsSuccessEdgeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SmsSuccessEdgeVariant2?(SmsSuccessEdge @this) => @this.SmsSuccessEdgeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SmsSuccessEdge(global::G.SmsSuccessEdgeVariant2? value)
        {
            SmsSuccessEdgeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SmsSuccessEdge(
            global::G.NodeEdge? node,
            global::G.SmsSuccessEdgeVariant2? smsSuccessEdgeVariant2
            )
        {
            Node = node;
            SmsSuccessEdgeVariant2 = smsSuccessEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SmsSuccessEdgeVariant2 as object ??
            Node as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Node?.ToString() ??
            SmsSuccessEdgeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNode && IsSmsSuccessEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeEdge?, TResult>? node = null,
            global::System.Func<global::G.SmsSuccessEdgeVariant2?, TResult>? smsSuccessEdgeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNode && node != null)
            {
                return node(Node!);
            }
            else if (IsSmsSuccessEdgeVariant2 && smsSuccessEdgeVariant2 != null)
            {
                return smsSuccessEdgeVariant2(SmsSuccessEdgeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeEdge?>? node = null,
            global::System.Action<global::G.SmsSuccessEdgeVariant2?>? smsSuccessEdgeVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNode)
            {
                node?.Invoke(Node!);
            }
            else if (IsSmsSuccessEdgeVariant2)
            {
                smsSuccessEdgeVariant2?.Invoke(SmsSuccessEdgeVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Node,
                typeof(global::G.NodeEdge),
                SmsSuccessEdgeVariant2,
                typeof(global::G.SmsSuccessEdgeVariant2),
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
        public bool Equals(SmsSuccessEdge other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeEdge?>.Default.Equals(Node, other.Node) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SmsSuccessEdgeVariant2?>.Default.Equals(SmsSuccessEdgeVariant2, other.SmsSuccessEdgeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SmsSuccessEdge obj1, SmsSuccessEdge obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmsSuccessEdge>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SmsSuccessEdge obj1, SmsSuccessEdge obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmsSuccessEdge o && Equals(o);
        }
    }
}
