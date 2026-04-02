//HintName: G.Models.GraphNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GraphNode : global::System.IEquatable<GraphNode>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant1? GraphNodeVariant1 { get; init; }
#else
        public global::G.GraphNodeVariant1? GraphNodeVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GraphNodeVariant1))]
#endif
        public bool IsGraphNodeVariant1 => GraphNodeVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant2? GraphNodeVariant2 { get; init; }
#else
        public global::G.GraphNodeVariant2? GraphNodeVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GraphNodeVariant2))]
#endif
        public bool IsGraphNodeVariant2 => GraphNodeVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant3? GraphNodeVariant3 { get; init; }
#else
        public global::G.GraphNodeVariant3? GraphNodeVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GraphNodeVariant3))]
#endif
        public bool IsGraphNodeVariant3 => GraphNodeVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant4? GraphNodeVariant4 { get; init; }
#else
        public global::G.GraphNodeVariant4? GraphNodeVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GraphNodeVariant4))]
#endif
        public bool IsGraphNodeVariant4 => GraphNodeVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant5? GraphNodeVariant5 { get; init; }
#else
        public global::G.GraphNodeVariant5? GraphNodeVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GraphNodeVariant5))]
#endif
        public bool IsGraphNodeVariant5 => GraphNodeVariant5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant6? GraphNodeVariant6 { get; init; }
#else
        public global::G.GraphNodeVariant6? GraphNodeVariant6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GraphNodeVariant6))]
#endif
        public bool IsGraphNodeVariant6 => GraphNodeVariant6 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant7? GraphNodeVariant7 { get; init; }
#else
        public global::G.GraphNodeVariant7? GraphNodeVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GraphNodeVariant7))]
#endif
        public bool IsGraphNodeVariant7 => GraphNodeVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant8? GraphNodeVariant8 { get; init; }
#else
        public global::G.GraphNodeVariant8? GraphNodeVariant8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GraphNodeVariant8))]
#endif
        public bool IsGraphNodeVariant8 => GraphNodeVariant8 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant1 value) => new GraphNode((global::G.GraphNodeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant1?(GraphNode @this) => @this.GraphNodeVariant1;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant1? value)
        {
            GraphNodeVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant2 value) => new GraphNode((global::G.GraphNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant2?(GraphNode @this) => @this.GraphNodeVariant2;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant2? value)
        {
            GraphNodeVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant3 value) => new GraphNode((global::G.GraphNodeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant3?(GraphNode @this) => @this.GraphNodeVariant3;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant3? value)
        {
            GraphNodeVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant4 value) => new GraphNode((global::G.GraphNodeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant4?(GraphNode @this) => @this.GraphNodeVariant4;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant4? value)
        {
            GraphNodeVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant5 value) => new GraphNode((global::G.GraphNodeVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant5?(GraphNode @this) => @this.GraphNodeVariant5;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant5? value)
        {
            GraphNodeVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant6 value) => new GraphNode((global::G.GraphNodeVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant6?(GraphNode @this) => @this.GraphNodeVariant6;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant6? value)
        {
            GraphNodeVariant6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant7 value) => new GraphNode((global::G.GraphNodeVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant7?(GraphNode @this) => @this.GraphNodeVariant7;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant7? value)
        {
            GraphNodeVariant7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant8 value) => new GraphNode((global::G.GraphNodeVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant8?(GraphNode @this) => @this.GraphNodeVariant8;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant8? value)
        {
            GraphNodeVariant8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(
            global::G.GraphNodeVariant1? graphNodeVariant1,
            global::G.GraphNodeVariant2? graphNodeVariant2,
            global::G.GraphNodeVariant3? graphNodeVariant3,
            global::G.GraphNodeVariant4? graphNodeVariant4,
            global::G.GraphNodeVariant5? graphNodeVariant5,
            global::G.GraphNodeVariant6? graphNodeVariant6,
            global::G.GraphNodeVariant7? graphNodeVariant7,
            global::G.GraphNodeVariant8? graphNodeVariant8
            )
        {
            GraphNodeVariant1 = graphNodeVariant1;
            GraphNodeVariant2 = graphNodeVariant2;
            GraphNodeVariant3 = graphNodeVariant3;
            GraphNodeVariant4 = graphNodeVariant4;
            GraphNodeVariant5 = graphNodeVariant5;
            GraphNodeVariant6 = graphNodeVariant6;
            GraphNodeVariant7 = graphNodeVariant7;
            GraphNodeVariant8 = graphNodeVariant8;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GraphNodeVariant8 as object ??
            GraphNodeVariant7 as object ??
            GraphNodeVariant6 as object ??
            GraphNodeVariant5 as object ??
            GraphNodeVariant4 as object ??
            GraphNodeVariant3 as object ??
            GraphNodeVariant2 as object ??
            GraphNodeVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GraphNodeVariant1?.ToString() ??
            GraphNodeVariant2?.ToString() ??
            GraphNodeVariant3?.ToString() ??
            GraphNodeVariant4?.ToString() ??
            GraphNodeVariant5?.ToString() ??
            GraphNodeVariant6?.ToString() ??
            GraphNodeVariant7?.ToString() ??
            GraphNodeVariant8?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGraphNodeVariant1 || IsGraphNodeVariant2 || IsGraphNodeVariant3 || IsGraphNodeVariant4 || IsGraphNodeVariant5 || IsGraphNodeVariant6 || IsGraphNodeVariant7 || IsGraphNodeVariant8;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GraphNodeVariant1?, TResult>? graphNodeVariant1 = null,
            global::System.Func<global::G.GraphNodeVariant2?, TResult>? graphNodeVariant2 = null,
            global::System.Func<global::G.GraphNodeVariant3?, TResult>? graphNodeVariant3 = null,
            global::System.Func<global::G.GraphNodeVariant4?, TResult>? graphNodeVariant4 = null,
            global::System.Func<global::G.GraphNodeVariant5?, TResult>? graphNodeVariant5 = null,
            global::System.Func<global::G.GraphNodeVariant6?, TResult>? graphNodeVariant6 = null,
            global::System.Func<global::G.GraphNodeVariant7?, TResult>? graphNodeVariant7 = null,
            global::System.Func<global::G.GraphNodeVariant8?, TResult>? graphNodeVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGraphNodeVariant1 && graphNodeVariant1 != null)
            {
                return graphNodeVariant1(GraphNodeVariant1!);
            }
            else if (IsGraphNodeVariant2 && graphNodeVariant2 != null)
            {
                return graphNodeVariant2(GraphNodeVariant2!);
            }
            else if (IsGraphNodeVariant3 && graphNodeVariant3 != null)
            {
                return graphNodeVariant3(GraphNodeVariant3!);
            }
            else if (IsGraphNodeVariant4 && graphNodeVariant4 != null)
            {
                return graphNodeVariant4(GraphNodeVariant4!);
            }
            else if (IsGraphNodeVariant5 && graphNodeVariant5 != null)
            {
                return graphNodeVariant5(GraphNodeVariant5!);
            }
            else if (IsGraphNodeVariant6 && graphNodeVariant6 != null)
            {
                return graphNodeVariant6(GraphNodeVariant6!);
            }
            else if (IsGraphNodeVariant7 && graphNodeVariant7 != null)
            {
                return graphNodeVariant7(GraphNodeVariant7!);
            }
            else if (IsGraphNodeVariant8 && graphNodeVariant8 != null)
            {
                return graphNodeVariant8(GraphNodeVariant8!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GraphNodeVariant1?>? graphNodeVariant1 = null,
            global::System.Action<global::G.GraphNodeVariant2?>? graphNodeVariant2 = null,
            global::System.Action<global::G.GraphNodeVariant3?>? graphNodeVariant3 = null,
            global::System.Action<global::G.GraphNodeVariant4?>? graphNodeVariant4 = null,
            global::System.Action<global::G.GraphNodeVariant5?>? graphNodeVariant5 = null,
            global::System.Action<global::G.GraphNodeVariant6?>? graphNodeVariant6 = null,
            global::System.Action<global::G.GraphNodeVariant7?>? graphNodeVariant7 = null,
            global::System.Action<global::G.GraphNodeVariant8?>? graphNodeVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGraphNodeVariant1)
            {
                graphNodeVariant1?.Invoke(GraphNodeVariant1!);
            }
            else if (IsGraphNodeVariant2)
            {
                graphNodeVariant2?.Invoke(GraphNodeVariant2!);
            }
            else if (IsGraphNodeVariant3)
            {
                graphNodeVariant3?.Invoke(GraphNodeVariant3!);
            }
            else if (IsGraphNodeVariant4)
            {
                graphNodeVariant4?.Invoke(GraphNodeVariant4!);
            }
            else if (IsGraphNodeVariant5)
            {
                graphNodeVariant5?.Invoke(GraphNodeVariant5!);
            }
            else if (IsGraphNodeVariant6)
            {
                graphNodeVariant6?.Invoke(GraphNodeVariant6!);
            }
            else if (IsGraphNodeVariant7)
            {
                graphNodeVariant7?.Invoke(GraphNodeVariant7!);
            }
            else if (IsGraphNodeVariant8)
            {
                graphNodeVariant8?.Invoke(GraphNodeVariant8!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GraphNodeVariant1,
                typeof(global::G.GraphNodeVariant1),
                GraphNodeVariant2,
                typeof(global::G.GraphNodeVariant2),
                GraphNodeVariant3,
                typeof(global::G.GraphNodeVariant3),
                GraphNodeVariant4,
                typeof(global::G.GraphNodeVariant4),
                GraphNodeVariant5,
                typeof(global::G.GraphNodeVariant5),
                GraphNodeVariant6,
                typeof(global::G.GraphNodeVariant6),
                GraphNodeVariant7,
                typeof(global::G.GraphNodeVariant7),
                GraphNodeVariant8,
                typeof(global::G.GraphNodeVariant8),
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
        public bool Equals(GraphNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant1?>.Default.Equals(GraphNodeVariant1, other.GraphNodeVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant2?>.Default.Equals(GraphNodeVariant2, other.GraphNodeVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant3?>.Default.Equals(GraphNodeVariant3, other.GraphNodeVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant4?>.Default.Equals(GraphNodeVariant4, other.GraphNodeVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant5?>.Default.Equals(GraphNodeVariant5, other.GraphNodeVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant6?>.Default.Equals(GraphNodeVariant6, other.GraphNodeVariant6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant7?>.Default.Equals(GraphNodeVariant7, other.GraphNodeVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant8?>.Default.Equals(GraphNodeVariant8, other.GraphNodeVariant8) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GraphNode obj1, GraphNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GraphNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GraphNode obj1, GraphNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GraphNode o && Equals(o);
        }
    }
}
