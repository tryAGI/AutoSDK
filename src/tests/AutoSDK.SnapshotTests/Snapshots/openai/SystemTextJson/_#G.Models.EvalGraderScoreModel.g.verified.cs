//HintName: G.Models.EvalGraderScoreModel.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EvalGraderScoreModel : global::System.IEquatable<EvalGraderScoreModel>
    {
        /// <summary>
        /// A ScoreModelGrader object that uses a model to assign a score to the input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.GraderScoreModel? Value1 { get; init; }
#else
        public global::G.GraderScoreModel? Value1 { get; }
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
        public global::G.EvalGraderScoreModelVariant2? Value2 { get; init; }
#else
        public global::G.EvalGraderScoreModelVariant2? Value2 { get; }
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
        public static implicit operator EvalGraderScoreModel(global::G.GraderScoreModel value) => new EvalGraderScoreModel((global::G.GraderScoreModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.GraderScoreModel?(EvalGraderScoreModel @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderScoreModel(global::G.GraderScoreModel? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator EvalGraderScoreModel(global::G.EvalGraderScoreModelVariant2 value) => new EvalGraderScoreModel((global::G.EvalGraderScoreModelVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.EvalGraderScoreModelVariant2?(EvalGraderScoreModel @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderScoreModel(global::G.EvalGraderScoreModelVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EvalGraderScoreModel(
            global::G.GraderScoreModel? value1,
            global::G.EvalGraderScoreModelVariant2? value2
            )
        {
            Value1 = value1;
            Value2 = value2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && IsValue2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.GraderScoreModel?, TResult>? value1 = null,
            global::System.Func<global::G.EvalGraderScoreModelVariant2?, TResult>? value2 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.GraderScoreModel?>? value1 = null,
            global::System.Action<global::G.EvalGraderScoreModelVariant2?>? value2 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.GraderScoreModel),
                Value2,
                typeof(global::G.EvalGraderScoreModelVariant2),
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
        public bool Equals(EvalGraderScoreModel other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.GraderScoreModel?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.EvalGraderScoreModelVariant2?>.Default.Equals(Value2, other.Value2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EvalGraderScoreModel obj1, EvalGraderScoreModel obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EvalGraderScoreModel>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EvalGraderScoreModel obj1, EvalGraderScoreModel obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EvalGraderScoreModel o && Equals(o);
        }
    }
}
