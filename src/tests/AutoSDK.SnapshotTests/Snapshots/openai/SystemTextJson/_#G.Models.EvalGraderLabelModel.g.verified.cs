//HintName: G.Models.EvalGraderLabelModel.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EvalGraderLabelModel : global::System.IEquatable<EvalGraderLabelModel>
    {
        /// <summary>
        /// A LabelModelGrader object which uses a model to assign labels to each item<br/>
        /// in the evaluation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraderLabelModel? Value1 { get; init; }
#else
        public global::G.GraderLabelModel? Value1 { get; }
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
        public static implicit operator EvalGraderLabelModel(global::G.GraderLabelModel value) => new EvalGraderLabelModel((global::G.GraderLabelModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraderLabelModel?(EvalGraderLabelModel @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderLabelModel(global::G.GraderLabelModel? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GraderLabelModel?, TResult>? value1 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GraderLabelModel?>? value1 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.GraderLabelModel),
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
        public bool Equals(EvalGraderLabelModel other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GraderLabelModel?>.Default.Equals(Value1, other.Value1) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalGraderLabelModel obj1, EvalGraderLabelModel obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalGraderLabelModel>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalGraderLabelModel obj1, EvalGraderLabelModel obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalGraderLabelModel o && Equals(o);
        }
    }
}
