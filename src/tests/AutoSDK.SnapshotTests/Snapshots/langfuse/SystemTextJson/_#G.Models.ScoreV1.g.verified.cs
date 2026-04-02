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
        public global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>? ScoreV1Variant1 { get; init; }
#else
        public global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>? ScoreV1Variant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreV1Variant1))]
#endif
        public bool IsScoreV1Variant1 => ScoreV1Variant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>? ScoreV1Variant2 { get; init; }
#else
        public global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>? ScoreV1Variant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreV1Variant2))]
#endif
        public bool IsScoreV1Variant2 => ScoreV1Variant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>? ScoreV1Variant3 { get; init; }
#else
        public global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>? ScoreV1Variant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreV1Variant3))]
#endif
        public bool IsScoreV1Variant3 => ScoreV1Variant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreV1(global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1> value) => new ScoreV1((global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>?(ScoreV1 @this) => @this.ScoreV1Variant1;

        /// <summary>
        /// 
        /// </summary>
        public ScoreV1(global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>? value)
        {
            ScoreV1Variant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreV1(global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1> value) => new ScoreV1((global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>?(ScoreV1 @this) => @this.ScoreV1Variant2;

        /// <summary>
        /// 
        /// </summary>
        public ScoreV1(global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>? value)
        {
            ScoreV1Variant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ScoreV1(global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1> value) => new ScoreV1((global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>?(ScoreV1 @this) => @this.ScoreV1Variant3;

        /// <summary>
        /// 
        /// </summary>
        public ScoreV1(global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>? value)
        {
            ScoreV1Variant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ScoreV1(
            global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>? scoreV1Variant1,
            global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>? scoreV1Variant2,
            global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>? scoreV1Variant3
            )
        {
            ScoreV1Variant1 = scoreV1Variant1;
            ScoreV1Variant2 = scoreV1Variant2;
            ScoreV1Variant3 = scoreV1Variant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScoreV1Variant3 as object ??
            ScoreV1Variant2 as object ??
            ScoreV1Variant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScoreV1Variant1?.ToString() ??
            ScoreV1Variant2?.ToString() ??
            ScoreV1Variant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScoreV1Variant1 && !IsScoreV1Variant2 && !IsScoreV1Variant3 || !IsScoreV1Variant1 && IsScoreV1Variant2 && !IsScoreV1Variant3 || !IsScoreV1Variant1 && !IsScoreV1Variant2 && IsScoreV1Variant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>?, TResult>? scoreV1Variant1 = null,
            global::System.Func<global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>?, TResult>? scoreV1Variant2 = null,
            global::System.Func<global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>?, TResult>? scoreV1Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreV1Variant1 && scoreV1Variant1 != null)
            {
                return scoreV1Variant1(ScoreV1Variant1!);
            }
            else if (IsScoreV1Variant2 && scoreV1Variant2 != null)
            {
                return scoreV1Variant2(ScoreV1Variant2!);
            }
            else if (IsScoreV1Variant3 && scoreV1Variant3 != null)
            {
                return scoreV1Variant3(ScoreV1Variant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>?>? scoreV1Variant1 = null,
            global::System.Action<global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>?>? scoreV1Variant2 = null,
            global::System.Action<global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>?>? scoreV1Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreV1Variant1)
            {
                scoreV1Variant1?.Invoke(ScoreV1Variant1!);
            }
            else if (IsScoreV1Variant2)
            {
                scoreV1Variant2?.Invoke(ScoreV1Variant2!);
            }
            else if (IsScoreV1Variant3)
            {
                scoreV1Variant3?.Invoke(ScoreV1Variant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScoreV1Variant1,
                typeof(global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>),
                ScoreV1Variant2,
                typeof(global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>),
                ScoreV1Variant3,
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
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.ScoreV1Variant12, global::G.NumericScoreV1>?>.Default.Equals(ScoreV1Variant1, other.ScoreV1Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>?>.Default.Equals(ScoreV1Variant2, other.ScoreV1Variant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>?>.Default.Equals(ScoreV1Variant3, other.ScoreV1Variant3) 
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
