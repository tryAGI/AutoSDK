//HintName: G.Models.EvalFilterNode.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EvalFilterNode : global::System.IEquatable<EvalFilterNode>
    {
        /// <summary>
        /// From T, pick a set of properties whose keys are in the union K
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PickFilterLeafRequestResponseRmt? Value1 { get; init; }
#else
        public global::G.PickFilterLeafRequestResponseRmt? Value1 { get; }
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
        public global::G.EvalFilterBranch? Value2 { get; init; }
#else
        public global::G.EvalFilterBranch? Value2 { get; }
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
        public global::G.EvalFilterNodeEnum? Value3 { get; init; }
#else
        public global::G.EvalFilterNodeEnum? Value3 { get; }
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
        public static implicit operator EvalFilterNode(global::G.PickFilterLeafRequestResponseRmt value) => new EvalFilterNode((global::G.PickFilterLeafRequestResponseRmt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PickFilterLeafRequestResponseRmt?(EvalFilterNode @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public EvalFilterNode(global::G.PickFilterLeafRequestResponseRmt? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalFilterNode(global::G.EvalFilterBranch value) => new EvalFilterNode((global::G.EvalFilterBranch?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EvalFilterBranch?(EvalFilterNode @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public EvalFilterNode(global::G.EvalFilterBranch? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalFilterNode(global::G.EvalFilterNodeEnum value) => new EvalFilterNode((global::G.EvalFilterNodeEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EvalFilterNodeEnum?(EvalFilterNode @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public EvalFilterNode(global::G.EvalFilterNodeEnum? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EvalFilterNode(
            global::G.PickFilterLeafRequestResponseRmt? value1,
            global::G.EvalFilterBranch? value2,
            global::G.EvalFilterNodeEnum? value3
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            Value3?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 || IsValue2 || IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PickFilterLeafRequestResponseRmt?, TResult>? value1 = null,
            global::System.Func<global::G.EvalFilterBranch?, TResult>? value2 = null,
            global::System.Func<global::G.EvalFilterNodeEnum?, TResult>? value3 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PickFilterLeafRequestResponseRmt?>? value1 = null,
            global::System.Action<global::G.EvalFilterBranch?>? value2 = null,
            global::System.Action<global::G.EvalFilterNodeEnum?>? value3 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.PickFilterLeafRequestResponseRmt),
                Value2,
                typeof(global::G.EvalFilterBranch),
                Value3,
                typeof(global::G.EvalFilterNodeEnum),
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
        public bool Equals(EvalFilterNode other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PickFilterLeafRequestResponseRmt?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EvalFilterBranch?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EvalFilterNodeEnum?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalFilterNode obj1, EvalFilterNode obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalFilterNode>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalFilterNode obj1, EvalFilterNode obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalFilterNode o && Equals(o);
        }
    }
}
