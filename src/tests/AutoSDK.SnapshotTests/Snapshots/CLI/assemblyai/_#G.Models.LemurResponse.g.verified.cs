//HintName: G.Models.LemurResponse.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LemurResponse : global::System.IEquatable<LemurResponse>
    {
        /// <summary>
        /// Example: {"request_id":"5e1b27c2-691f-4414-8bc5-f14678442f9e","response":"Based on the transcript, the following locations were mentioned as being affected by wildfire smoke from Canada:\n\n- Maine\n- Maryland\n- Minnesota\n- Mid Atlantic region\n- Northeast region\n- New York City\n- Baltimore\n","usage":{"input_tokens":27,"output_tokens":3}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LemurStringResponse? String { get; init; }
#else
        public global::G.LemurStringResponse? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// Example: {"request_id":"5e1b27c2-691f-4414-8bc5-f14678442f9e","response":[{"answer":"CA, US","question":"Where are there wildfires?"},{"answer":"yes","question":"Is global warming affecting wildfires?"}],"usage":{"input_tokens":27,"output_tokens":3}}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LemurQuestionAnswerResponse? QuestionAnswer { get; init; }
#else
        public global::G.LemurQuestionAnswerResponse? QuestionAnswer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QuestionAnswer))]
#endif
        public bool IsQuestionAnswer => QuestionAnswer != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurResponse(global::G.LemurStringResponse value) => new LemurResponse((global::G.LemurStringResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurStringResponse?(LemurResponse @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public LemurResponse(global::G.LemurStringResponse? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurResponse(global::G.LemurQuestionAnswerResponse value) => new LemurResponse((global::G.LemurQuestionAnswerResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurQuestionAnswerResponse?(LemurResponse @this) => @this.QuestionAnswer;

        /// <summary>
        /// 
        /// </summary>
        public LemurResponse(global::G.LemurQuestionAnswerResponse? value)
        {
            QuestionAnswer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LemurResponse(
            global::G.LemurStringResponse? @string,
            global::G.LemurQuestionAnswerResponse? questionAnswer
            )
        {
            String = @string;
            QuestionAnswer = questionAnswer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            QuestionAnswer as object ??
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            QuestionAnswer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsQuestionAnswer || !IsString && IsQuestionAnswer;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LemurStringResponse?, TResult>? @string = null,
            global::System.Func<global::G.LemurQuestionAnswerResponse?, TResult>? questionAnswer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsQuestionAnswer && questionAnswer != null)
            {
                return questionAnswer(QuestionAnswer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LemurStringResponse?>? @string = null,
            global::System.Action<global::G.LemurQuestionAnswerResponse?>? questionAnswer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsQuestionAnswer)
            {
                questionAnswer?.Invoke(QuestionAnswer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::G.LemurStringResponse),
                QuestionAnswer,
                typeof(global::G.LemurQuestionAnswerResponse),
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
        public bool Equals(LemurResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LemurStringResponse?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LemurQuestionAnswerResponse?>.Default.Equals(QuestionAnswer, other.QuestionAnswer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurResponse obj1, LemurResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurResponse obj1, LemurResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurResponse o && Equals(o);
        }
    }
}
