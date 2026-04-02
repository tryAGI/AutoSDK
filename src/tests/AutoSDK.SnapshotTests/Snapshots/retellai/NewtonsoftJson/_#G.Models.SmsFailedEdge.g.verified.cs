//HintName: G.Models.SmsFailedEdge.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct SmsFailedEdge : global::System.IEquatable<SmsFailedEdge>
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
        public global::G.SmsFailedEdgeVariant2? SmsFailedEdgeVariant2 { get; init; }
#else
        public global::G.SmsFailedEdgeVariant2? SmsFailedEdgeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SmsFailedEdgeVariant2))]
#endif
        public bool IsSmsFailedEdgeVariant2 => SmsFailedEdgeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsFailedEdge(global::G.NodeEdge value) => new SmsFailedEdge((global::G.NodeEdge?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeEdge?(SmsFailedEdge @this) => @this.Node;

        /// <summary>
        /// 
        /// </summary>
        public SmsFailedEdge(global::G.NodeEdge? value)
        {
            Node = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator SmsFailedEdge(global::G.SmsFailedEdgeVariant2 value) => new SmsFailedEdge((global::G.SmsFailedEdgeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.SmsFailedEdgeVariant2?(SmsFailedEdge @this) => @this.SmsFailedEdgeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public SmsFailedEdge(global::G.SmsFailedEdgeVariant2? value)
        {
            SmsFailedEdgeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public SmsFailedEdge(
            global::G.NodeEdge? node,
            global::G.SmsFailedEdgeVariant2? smsFailedEdgeVariant2
            )
        {
            Node = node;
            SmsFailedEdgeVariant2 = smsFailedEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SmsFailedEdgeVariant2 as object ??
            Node as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Node?.ToString() ??
            SmsFailedEdgeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNode && IsSmsFailedEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeEdge?, TResult>? node = null,
            global::System.Func<global::G.SmsFailedEdgeVariant2?, TResult>? smsFailedEdgeVariant2 = null,
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
            else if (IsSmsFailedEdgeVariant2 && smsFailedEdgeVariant2 != null)
            {
                return smsFailedEdgeVariant2(SmsFailedEdgeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeEdge?>? node = null,
            global::System.Action<global::G.SmsFailedEdgeVariant2?>? smsFailedEdgeVariant2 = null,
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
            else if (IsSmsFailedEdgeVariant2)
            {
                smsFailedEdgeVariant2?.Invoke(SmsFailedEdgeVariant2!);
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
                SmsFailedEdgeVariant2,
                typeof(global::G.SmsFailedEdgeVariant2),
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
        public bool Equals(SmsFailedEdge other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeEdge?>.Default.Equals(Node, other.Node) &&
                global::System.Collections.Generic.EqualityComparer<global::G.SmsFailedEdgeVariant2?>.Default.Equals(SmsFailedEdgeVariant2, other.SmsFailedEdgeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(SmsFailedEdge obj1, SmsFailedEdge obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SmsFailedEdge>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(SmsFailedEdge obj1, SmsFailedEdge obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SmsFailedEdge o && Equals(o);
        }
    }
}
