//HintName: G.Models.Score.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Score : global::System.IEquatable<Score>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>? ScoreVariant1 { get; init; }
#else
        public global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>? ScoreVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreVariant1))]
#endif
        public bool IsScoreVariant1 => ScoreVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>? ScoreVariant2 { get; init; }
#else
        public global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>? ScoreVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreVariant2))]
#endif
        public bool IsScoreVariant2 => ScoreVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>? ScoreVariant3 { get; init; }
#else
        public global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>? ScoreVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreVariant3))]
#endif
        public bool IsScoreVariant3 => ScoreVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>? ScoreVariant4 { get; init; }
#else
        public global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>? ScoreVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScoreVariant4))]
#endif
        public bool IsScoreVariant4 => ScoreVariant4 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore> value) => new Score((global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>?(Score @this) => @this.ScoreVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>? value)
        {
            ScoreVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore> value) => new Score((global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>?(Score @this) => @this.ScoreVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>? value)
        {
            ScoreVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore> value) => new Score((global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>?(Score @this) => @this.ScoreVariant3;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>? value)
        {
            ScoreVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Score(global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore> value) => new Score((global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>?(Score @this) => @this.ScoreVariant4;

        /// <summary>
        /// 
        /// </summary>
        public Score(global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>? value)
        {
            ScoreVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Score(
            global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>? scoreVariant1,
            global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>? scoreVariant2,
            global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>? scoreVariant3,
            global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>? scoreVariant4
            )
        {
            ScoreVariant1 = scoreVariant1;
            ScoreVariant2 = scoreVariant2;
            ScoreVariant3 = scoreVariant3;
            ScoreVariant4 = scoreVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ScoreVariant4 as object ??
            ScoreVariant3 as object ??
            ScoreVariant2 as object ??
            ScoreVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ScoreVariant1?.ToString() ??
            ScoreVariant2?.ToString() ??
            ScoreVariant3?.ToString() ??
            ScoreVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsScoreVariant1 && !IsScoreVariant2 && !IsScoreVariant3 && !IsScoreVariant4 || !IsScoreVariant1 && IsScoreVariant2 && !IsScoreVariant3 && !IsScoreVariant4 || !IsScoreVariant1 && !IsScoreVariant2 && IsScoreVariant3 && !IsScoreVariant4 || !IsScoreVariant1 && !IsScoreVariant2 && !IsScoreVariant3 && IsScoreVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>?, TResult>? scoreVariant1 = null,
            global::System.Func<global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>?, TResult>? scoreVariant2 = null,
            global::System.Func<global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>?, TResult>? scoreVariant3 = null,
            global::System.Func<global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>?, TResult>? scoreVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreVariant1 && scoreVariant1 != null)
            {
                return scoreVariant1(ScoreVariant1!);
            }
            else if (IsScoreVariant2 && scoreVariant2 != null)
            {
                return scoreVariant2(ScoreVariant2!);
            }
            else if (IsScoreVariant3 && scoreVariant3 != null)
            {
                return scoreVariant3(ScoreVariant3!);
            }
            else if (IsScoreVariant4 && scoreVariant4 != null)
            {
                return scoreVariant4(ScoreVariant4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>?>? scoreVariant1 = null,
            global::System.Action<global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>?>? scoreVariant2 = null,
            global::System.Action<global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>?>? scoreVariant3 = null,
            global::System.Action<global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>?>? scoreVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsScoreVariant1)
            {
                scoreVariant1?.Invoke(ScoreVariant1!);
            }
            else if (IsScoreVariant2)
            {
                scoreVariant2?.Invoke(ScoreVariant2!);
            }
            else if (IsScoreVariant3)
            {
                scoreVariant3?.Invoke(ScoreVariant3!);
            }
            else if (IsScoreVariant4)
            {
                scoreVariant4?.Invoke(ScoreVariant4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ScoreVariant1,
                typeof(global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>),
                ScoreVariant2,
                typeof(global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>),
                ScoreVariant3,
                typeof(global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>),
                ScoreVariant4,
                typeof(global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>),
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
        public bool Equals(Score other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.ScoreVariant12, global::G.NumericScore>?>.Default.Equals(ScoreVariant1, other.ScoreVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.ScoreVariant22, global::G.CategoricalScore>?>.Default.Equals(ScoreVariant2, other.ScoreVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.ScoreVariant32, global::G.BooleanScore>?>.Default.Equals(ScoreVariant3, other.ScoreVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AllOf<global::G.ScoreVariant42, global::G.CorrectionScore>?>.Default.Equals(ScoreVariant4, other.ScoreVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Score obj1, Score obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Score>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Score obj1, Score obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Score o && Equals(o);
        }
    }
}
