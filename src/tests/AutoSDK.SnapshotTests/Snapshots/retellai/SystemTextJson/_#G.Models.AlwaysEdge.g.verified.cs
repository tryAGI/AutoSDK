//HintName: G.Models.AlwaysEdge.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AlwaysEdge : global::System.IEquatable<AlwaysEdge>
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
        public global::G.AlwaysEdgeVariant2? AlwaysEdgeVariant2 { get; init; }
#else
        public global::G.AlwaysEdgeVariant2? AlwaysEdgeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AlwaysEdgeVariant2))]
#endif
        public bool IsAlwaysEdgeVariant2 => AlwaysEdgeVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AlwaysEdge(global::G.NodeEdge value) => new AlwaysEdge((global::G.NodeEdge?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.NodeEdge?(AlwaysEdge @this) => @this.Node;

        /// <summary>
        /// 
        /// </summary>
        public AlwaysEdge(global::G.NodeEdge? value)
        {
            Node = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AlwaysEdge(global::G.AlwaysEdgeVariant2 value) => new AlwaysEdge((global::G.AlwaysEdgeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AlwaysEdgeVariant2?(AlwaysEdge @this) => @this.AlwaysEdgeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public AlwaysEdge(global::G.AlwaysEdgeVariant2? value)
        {
            AlwaysEdgeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AlwaysEdge(
            global::G.NodeEdge? node,
            global::G.AlwaysEdgeVariant2? alwaysEdgeVariant2
            )
        {
            Node = node;
            AlwaysEdgeVariant2 = alwaysEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AlwaysEdgeVariant2 as object ??
            Node as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Node?.ToString() ??
            AlwaysEdgeVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNode && IsAlwaysEdgeVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.NodeEdge?, TResult>? node = null,
            global::System.Func<global::G.AlwaysEdgeVariant2?, TResult>? alwaysEdgeVariant2 = null,
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
            else if (IsAlwaysEdgeVariant2 && alwaysEdgeVariant2 != null)
            {
                return alwaysEdgeVariant2(AlwaysEdgeVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.NodeEdge?>? node = null,
            global::System.Action<global::G.AlwaysEdgeVariant2?>? alwaysEdgeVariant2 = null,
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
            else if (IsAlwaysEdgeVariant2)
            {
                alwaysEdgeVariant2?.Invoke(AlwaysEdgeVariant2!);
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
                AlwaysEdgeVariant2,
                typeof(global::G.AlwaysEdgeVariant2),
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
        public bool Equals(AlwaysEdge other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.NodeEdge?>.Default.Equals(Node, other.Node) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AlwaysEdgeVariant2?>.Default.Equals(AlwaysEdgeVariant2, other.AlwaysEdgeVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AlwaysEdge obj1, AlwaysEdge obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AlwaysEdge>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AlwaysEdge obj1, AlwaysEdge obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AlwaysEdge o && Equals(o);
        }
    }
}
