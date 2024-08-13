//HintName: G.Models.AssistantsApiResponseFormatOption.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models/gpt-4o), [GPT-4 Turbo](/docs/models/gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
    /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which guarantees the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
    /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
    /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
    /// </summary>
    public readonly partial struct AssistantsApiResponseFormatOption : global::System.IEquatable<AssistantsApiResponseFormatOption>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.AssistantsApiResponseFormatOptionEnum? Value1 { get; init; }
#else
        public global::G.AssistantsApiResponseFormatOptionEnum? Value1 { get; }
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
        public static implicit operator AssistantsApiResponseFormatOption(global::G.AssistantsApiResponseFormatOptionEnum value) => new AssistantsApiResponseFormatOption(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.AssistantsApiResponseFormatOptionEnum?(AssistantsApiResponseFormatOption @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(global::G.AssistantsApiResponseFormatOptionEnum? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFormatText? Value2 { get; init; }
#else
        public global::G.ResponseFormatText? Value2 { get; }
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
        public static implicit operator AssistantsApiResponseFormatOption(global::G.ResponseFormatText value) => new AssistantsApiResponseFormatOption(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatText?(AssistantsApiResponseFormatOption @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(global::G.ResponseFormatText? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFormatJsonObject? Value3 { get; init; }
#else
        public global::G.ResponseFormatJsonObject? Value3 { get; }
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
        public static implicit operator AssistantsApiResponseFormatOption(global::G.ResponseFormatJsonObject value) => new AssistantsApiResponseFormatOption(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatJsonObject?(AssistantsApiResponseFormatOption @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(global::G.ResponseFormatJsonObject? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFormatJsonSchema? Value4 { get; init; }
#else
        public global::G.ResponseFormatJsonSchema? Value4 { get; }
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
        public static implicit operator AssistantsApiResponseFormatOption(global::G.ResponseFormatJsonSchema value) => new AssistantsApiResponseFormatOption(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatJsonSchema?(AssistantsApiResponseFormatOption @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(global::G.ResponseFormatJsonSchema? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(
            global::G.AssistantsApiResponseFormatOptionEnum? value1,
            global::G.ResponseFormatText? value2,
            global::G.ResponseFormatJsonObject? value3,
            global::G.ResponseFormatJsonSchema? value4
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.AssistantsApiResponseFormatOptionEnum),
                Value2,
                typeof(global::G.ResponseFormatText),
                Value3,
                typeof(global::G.ResponseFormatJsonObject),
                Value4,
                typeof(global::G.ResponseFormatJsonSchema),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AssistantsApiResponseFormatOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantsApiResponseFormatOptionEnum?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatText?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatJsonObject?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatJsonSchema?>.Default.Equals(Value4, other.Value4) 
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
