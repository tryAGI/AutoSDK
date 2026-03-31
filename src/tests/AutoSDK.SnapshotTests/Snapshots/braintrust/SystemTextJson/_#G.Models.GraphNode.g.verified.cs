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
        public global::G.GraphNodeVariant1? Value1 { get; init; }
#else
        public global::G.GraphNodeVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant2? Value2 { get; init; }
#else
        public global::G.GraphNodeVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant3? Value3 { get; init; }
#else
        public global::G.GraphNodeVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant4? Value4 { get; init; }
#else
        public global::G.GraphNodeVariant4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant5? Value5 { get; init; }
#else
        public global::G.GraphNodeVariant5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant6? Value6 { get; init; }
#else
        public global::G.GraphNodeVariant6? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant7? Value7 { get; init; }
#else
        public global::G.GraphNodeVariant7? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraphNodeVariant8? Value8 { get; init; }
#else
        public global::G.GraphNodeVariant8? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant1 value) => new GraphNode((global::G.GraphNodeVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant1?(GraphNode @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant2 value) => new GraphNode((global::G.GraphNodeVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant2?(GraphNode @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant3 value) => new GraphNode((global::G.GraphNodeVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant3?(GraphNode @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant4 value) => new GraphNode((global::G.GraphNodeVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant4?(GraphNode @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant5 value) => new GraphNode((global::G.GraphNodeVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant5?(GraphNode @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant6 value) => new GraphNode((global::G.GraphNodeVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant6?(GraphNode @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant6? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant7 value) => new GraphNode((global::G.GraphNodeVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant7?(GraphNode @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant7? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GraphNode(global::G.GraphNodeVariant8 value) => new GraphNode((global::G.GraphNodeVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraphNodeVariant8?(GraphNode @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(global::G.GraphNodeVariant8? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GraphNode(
            global::G.GraphNodeVariant1? value1,
            global::G.GraphNodeVariant2? value2,
            global::G.GraphNodeVariant3? value3,
            global::G.GraphNodeVariant4? value4,
            global::G.GraphNodeVariant5? value5,
            global::G.GraphNodeVariant6? value6,
            global::G.GraphNodeVariant7? value7,
            global::G.GraphNodeVariant8? value8
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() ??
            Value7?.ToString() ??
            Value8?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3 || IsValue4 || IsValue5 || IsValue6 || IsValue7 || IsValue8;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GraphNodeVariant1?, TResult>? value1 = null,
            global::System.Func<global::G.GraphNodeVariant2?, TResult>? value2 = null,
            global::System.Func<global::G.GraphNodeVariant3?, TResult>? value3 = null,
            global::System.Func<global::G.GraphNodeVariant4?, TResult>? value4 = null,
            global::System.Func<global::G.GraphNodeVariant5?, TResult>? value5 = null,
            global::System.Func<global::G.GraphNodeVariant6?, TResult>? value6 = null,
            global::System.Func<global::G.GraphNodeVariant7?, TResult>? value7 = null,
            global::System.Func<global::G.GraphNodeVariant8?, TResult>? value8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GraphNodeVariant1?>? value1 = null,
            global::System.Action<global::G.GraphNodeVariant2?>? value2 = null,
            global::System.Action<global::G.GraphNodeVariant3?>? value3 = null,
            global::System.Action<global::G.GraphNodeVariant4?>? value4 = null,
            global::System.Action<global::G.GraphNodeVariant5?>? value5 = null,
            global::System.Action<global::G.GraphNodeVariant6?>? value6 = null,
            global::System.Action<global::G.GraphNodeVariant7?>? value7 = null,
            global::System.Action<global::G.GraphNodeVariant8?>? value8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.GraphNodeVariant1),
                Value2,
                typeof(global::G.GraphNodeVariant2),
                Value3,
                typeof(global::G.GraphNodeVariant3),
                Value4,
                typeof(global::G.GraphNodeVariant4),
                Value5,
                typeof(global::G.GraphNodeVariant5),
                Value6,
                typeof(global::G.GraphNodeVariant6),
                Value7,
                typeof(global::G.GraphNodeVariant7),
                Value8,
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
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant5?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant6?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant7?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::G.GraphNodeVariant8?>.Default.Equals(Value8, other.Value8) 
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
