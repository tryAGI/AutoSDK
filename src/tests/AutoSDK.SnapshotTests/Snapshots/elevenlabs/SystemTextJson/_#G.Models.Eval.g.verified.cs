//HintName: G.Models.Eval.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Eval : global::System.IEquatable<Eval>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.UnitTestToolCallParameterEvalDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LLMParameterEvaluationStrategy? Llm { get; init; }
#else
        public global::G.LLMParameterEvaluationStrategy? Llm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Llm))]
#endif
        public bool IsLlm => Llm != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.RegexParameterEvaluationStrategy? Regex { get; init; }
#else
        public global::G.RegexParameterEvaluationStrategy? Regex { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Regex))]
#endif
        public bool IsRegex => Regex != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ExactParameterEvaluationStrategy? Exact { get; init; }
#else
        public global::G.ExactParameterEvaluationStrategy? Exact { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Exact))]
#endif
        public bool IsExact => Exact != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.MatchAnythingParameterEvaluationStrategy? Anything { get; init; }
#else
        public global::G.MatchAnythingParameterEvaluationStrategy? Anything { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Anything))]
#endif
        public bool IsAnything => Anything != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Eval(global::G.LLMParameterEvaluationStrategy value) => new Eval((global::G.LLMParameterEvaluationStrategy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LLMParameterEvaluationStrategy?(Eval @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public Eval(global::G.LLMParameterEvaluationStrategy? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Eval(global::G.RegexParameterEvaluationStrategy value) => new Eval((global::G.RegexParameterEvaluationStrategy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.RegexParameterEvaluationStrategy?(Eval @this) => @this.Regex;

        /// <summary>
        /// 
        /// </summary>
        public Eval(global::G.RegexParameterEvaluationStrategy? value)
        {
            Regex = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Eval(global::G.ExactParameterEvaluationStrategy value) => new Eval((global::G.ExactParameterEvaluationStrategy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ExactParameterEvaluationStrategy?(Eval @this) => @this.Exact;

        /// <summary>
        /// 
        /// </summary>
        public Eval(global::G.ExactParameterEvaluationStrategy? value)
        {
            Exact = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Eval(global::G.MatchAnythingParameterEvaluationStrategy value) => new Eval((global::G.MatchAnythingParameterEvaluationStrategy?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.MatchAnythingParameterEvaluationStrategy?(Eval @this) => @this.Anything;

        /// <summary>
        /// 
        /// </summary>
        public Eval(global::G.MatchAnythingParameterEvaluationStrategy? value)
        {
            Anything = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Eval(
            global::G.UnitTestToolCallParameterEvalDiscriminatorType? type,
            global::G.LLMParameterEvaluationStrategy? llm,
            global::G.RegexParameterEvaluationStrategy? regex,
            global::G.ExactParameterEvaluationStrategy? exact,
            global::G.MatchAnythingParameterEvaluationStrategy? anything
            )
        {
            Type = type;

            Llm = llm;
            Regex = regex;
            Exact = exact;
            Anything = anything;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Anything as object ??
            Exact as object ??
            Regex as object ??
            Llm as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Llm?.ToString() ??
            Regex?.ToString() ??
            Exact?.ToString() ??
            Anything?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsLlm && !IsRegex && !IsExact && !IsAnything || !IsLlm && IsRegex && !IsExact && !IsAnything || !IsLlm && !IsRegex && IsExact && !IsAnything || !IsLlm && !IsRegex && !IsExact && IsAnything;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LLMParameterEvaluationStrategy?, TResult>? llm = null,
            global::System.Func<global::G.RegexParameterEvaluationStrategy?, TResult>? regex = null,
            global::System.Func<global::G.ExactParameterEvaluationStrategy?, TResult>? exact = null,
            global::System.Func<global::G.MatchAnythingParameterEvaluationStrategy?, TResult>? anything = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLlm && llm != null)
            {
                return llm(Llm!);
            }
            else if (IsRegex && regex != null)
            {
                return regex(Regex!);
            }
            else if (IsExact && exact != null)
            {
                return exact(Exact!);
            }
            else if (IsAnything && anything != null)
            {
                return anything(Anything!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LLMParameterEvaluationStrategy?>? llm = null,
            global::System.Action<global::G.RegexParameterEvaluationStrategy?>? regex = null,
            global::System.Action<global::G.ExactParameterEvaluationStrategy?>? exact = null,
            global::System.Action<global::G.MatchAnythingParameterEvaluationStrategy?>? anything = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
            else if (IsRegex)
            {
                regex?.Invoke(Regex!);
            }
            else if (IsExact)
            {
                exact?.Invoke(Exact!);
            }
            else if (IsAnything)
            {
                anything?.Invoke(Anything!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Llm,
                typeof(global::G.LLMParameterEvaluationStrategy),
                Regex,
                typeof(global::G.RegexParameterEvaluationStrategy),
                Exact,
                typeof(global::G.ExactParameterEvaluationStrategy),
                Anything,
                typeof(global::G.MatchAnythingParameterEvaluationStrategy),
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
        public bool Equals(Eval other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LLMParameterEvaluationStrategy?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::G.RegexParameterEvaluationStrategy?>.Default.Equals(Regex, other.Regex) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ExactParameterEvaluationStrategy?>.Default.Equals(Exact, other.Exact) &&
                global::System.Collections.Generic.EqualityComparer<global::G.MatchAnythingParameterEvaluationStrategy?>.Default.Equals(Anything, other.Anything) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Eval obj1, Eval obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Eval>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Eval obj1, Eval obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Eval o && Equals(o);
        }
    }
}
