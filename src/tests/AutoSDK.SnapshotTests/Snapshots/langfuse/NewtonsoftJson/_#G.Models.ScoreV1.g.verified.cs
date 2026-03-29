//HintName: G.Models.ScoreV1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ScoreV1 : global::System.IEquatable<ScoreV1>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>? Value1 { get; init; }
#else
        public global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>? Value1 { get; }
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
        public global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>? Value2 { get; init; }
#else
        public global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>? Value2 { get; }
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
        public global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>? Value3 { get; init; }
#else
        public global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>? Value3 { get; }
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
        public static implicit operator ScoreV1(global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1> value) => new ScoreV1((global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>?(ScoreV1 @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public ScoreV1(global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreV1(global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1> value) => new ScoreV1((global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>?(ScoreV1 @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public ScoreV1(global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreV1(global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1> value) => new ScoreV1((global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>?(ScoreV1 @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public ScoreV1(global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ScoreV1(
            global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>? value1,
            global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>? value2,
            global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>? value3
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
            Value3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 || !IsValue1 && IsValue2 && !IsValue3 || !IsValue1 && !IsValue2 && IsValue3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>?, TResult>? value1 = null,
            global::System.Func<global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>?, TResult>? value2 = null,
            global::System.Func<global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>?, TResult>? value3 = null,
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
            global::System.Action<global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>?>? value1 = null,
            global::System.Action<global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>?>? value2 = null,
            global::System.Action<global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>?>? value3 = null,
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
                typeof(global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>),
                Value2,
                typeof(global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>),
                Value3,
                typeof(global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>),
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
        public bool Equals(ScoreV1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>?>.Default.Equals(Value3, other.Value3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ScoreV1 obj1, ScoreV1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ScoreV1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ScoreV1 obj1, ScoreV1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ScoreV1 o && Equals(o);
        }
    }
}
