//HintName: G.Models.AssistantsApiResponseFormatOption.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the format that the model must output. Compatible with [GPT-4o](https://platform.openai.com/docs/models/gpt-4o), [GPT-4 Turbo](https://platform.openai.com/docs/models/gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
    /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
    /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
    /// </summary>
    public readonly partial struct AssistantsApiResponseFormatOption : global::System.IEquatable<AssistantsApiResponseFormatOption>
    {
        /// <summary>
        /// `auto` is the default value
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantsApiResponseFormatOptionEnum? Enum { get; init; }
#else
        public global::G.AssistantsApiResponseFormatOptionEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// An object describing the expected output of the model. If `json_object` only `function` type `tools` are allowed to be passed to the Run. If `text` the model can return text or any value needed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantsApiResponseFormat? AssistantsApiResponseFormat { get; init; }
#else
        public global::G.AssistantsApiResponseFormat? AssistantsApiResponseFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssistantsApiResponseFormat))]
#endif
        public bool IsAssistantsApiResponseFormat => AssistantsApiResponseFormat != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantsApiResponseFormatOption(global::G.AssistantsApiResponseFormatOptionEnum value) => new AssistantsApiResponseFormatOption((global::G.AssistantsApiResponseFormatOptionEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantsApiResponseFormatOptionEnum?(AssistantsApiResponseFormatOption @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(global::G.AssistantsApiResponseFormatOptionEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantsApiResponseFormatOption(global::G.AssistantsApiResponseFormat value) => new AssistantsApiResponseFormatOption((global::G.AssistantsApiResponseFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantsApiResponseFormat?(AssistantsApiResponseFormatOption @this) => @this.AssistantsApiResponseFormat;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(global::G.AssistantsApiResponseFormat? value)
        {
            AssistantsApiResponseFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(
            global::G.AssistantsApiResponseFormatOptionEnum? @enum,
            global::G.AssistantsApiResponseFormat? assistantsApiResponseFormat
            )
        {
            Enum = @enum;
            AssistantsApiResponseFormat = assistantsApiResponseFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AssistantsApiResponseFormat as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            AssistantsApiResponseFormat?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsAssistantsApiResponseFormat || !IsEnum && IsAssistantsApiResponseFormat;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AssistantsApiResponseFormatOptionEnum?, TResult>? @enum = null,
            global::System.Func<global::G.AssistantsApiResponseFormat?, TResult>? assistantsApiResponseFormat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsAssistantsApiResponseFormat && assistantsApiResponseFormat != null)
            {
                return assistantsApiResponseFormat(AssistantsApiResponseFormat!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AssistantsApiResponseFormatOptionEnum?>? @enum = null,
            global::System.Action<global::G.AssistantsApiResponseFormat?>? assistantsApiResponseFormat = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsAssistantsApiResponseFormat)
            {
                assistantsApiResponseFormat?.Invoke(AssistantsApiResponseFormat!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::G.AssistantsApiResponseFormatOptionEnum),
                AssistantsApiResponseFormat,
                typeof(global::G.AssistantsApiResponseFormat),
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
        public bool Equals(AssistantsApiResponseFormatOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantsApiResponseFormatOptionEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantsApiResponseFormat?>.Default.Equals(AssistantsApiResponseFormat, other.AssistantsApiResponseFormat) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AssistantsApiResponseFormatOption obj1, AssistantsApiResponseFormatOption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AssistantsApiResponseFormatOption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AssistantsApiResponseFormatOption obj1, AssistantsApiResponseFormatOption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AssistantsApiResponseFormatOption o && Equals(o);
        }
    }
}
