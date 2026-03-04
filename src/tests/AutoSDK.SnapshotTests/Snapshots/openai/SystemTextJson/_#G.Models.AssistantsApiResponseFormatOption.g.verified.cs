//HintName: G.Models.AssistantsApiResponseFormatOption.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models#gpt-4o), [GPT-4 Turbo](/docs/models#gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
    /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
    /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures the message the model generates is valid JSON.<br/>
    /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
    /// </summary>
    public readonly partial struct AssistantsApiResponseFormatOption : global::System.IEquatable<AssistantsApiResponseFormatOption>
    {
        /// <summary>
        /// `auto` is the default value
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
        /// Default response format. Used to generate text responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFormatText? Text { get; init; }
#else
        public global::G.ResponseFormatText? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// JSON object response format. An older method of generating JSON responses.<br/>
        /// Using `json_schema` is recommended for models that support it. Note that the<br/>
        /// model will not generate JSON without a system or user message instructing it<br/>
        /// to do so.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFormatJsonObject? JsonObject { get; init; }
#else
        public global::G.ResponseFormatJsonObject? JsonObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonObject))]
#endif
        public bool IsJsonObject => JsonObject != null;

        /// <summary>
        /// JSON Schema response format. Used to generate structured JSON responses.<br/>
        /// Learn more about [Structured Outputs](/docs/guides/structured-outputs).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFormatJsonSchema? JsonSchema { get; init; }
#else
        public global::G.ResponseFormatJsonSchema? JsonSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchema))]
#endif
        public bool IsJsonSchema => JsonSchema != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantsApiResponseFormatOption(global::G.AssistantsApiResponseFormatOptionEnum value) => new AssistantsApiResponseFormatOption((global::G.AssistantsApiResponseFormatOptionEnum?)value);

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
        public static implicit operator AssistantsApiResponseFormatOption(global::G.ResponseFormatText value) => new AssistantsApiResponseFormatOption((global::G.ResponseFormatText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatText?(AssistantsApiResponseFormatOption @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(global::G.ResponseFormatText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantsApiResponseFormatOption(global::G.ResponseFormatJsonObject value) => new AssistantsApiResponseFormatOption((global::G.ResponseFormatJsonObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatJsonObject?(AssistantsApiResponseFormatOption @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(global::G.ResponseFormatJsonObject? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AssistantsApiResponseFormatOption(global::G.ResponseFormatJsonSchema value) => new AssistantsApiResponseFormatOption((global::G.ResponseFormatJsonSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatJsonSchema?(AssistantsApiResponseFormatOption @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(global::G.ResponseFormatJsonSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AssistantsApiResponseFormatOption(
            global::G.AssistantsApiResponseFormatOptionEnum? value1,
            global::G.ResponseFormatText? text,
            global::G.ResponseFormatJsonObject? jsonObject,
            global::G.ResponseFormatJsonSchema? jsonSchema
            )
        {
            Value1 = value1;
            Text = text;
            JsonObject = jsonObject;
            JsonSchema = jsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonSchema as object ??
            JsonObject as object ??
            Text as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToValueString() ??
            Text?.ToString() ??
            JsonObject?.ToString() ??
            JsonSchema?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsText && !IsJsonObject && !IsJsonSchema || !IsValue1 && IsText && !IsJsonObject && !IsJsonSchema || !IsValue1 && !IsText && IsJsonObject && !IsJsonSchema || !IsValue1 && !IsText && !IsJsonObject && IsJsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.AssistantsApiResponseFormatOptionEnum?, TResult>? value1 = null,
            global::System.Func<global::G.ResponseFormatText?, TResult>? text = null,
            global::System.Func<global::G.ResponseFormatJsonObject?, TResult>? jsonObject = null,
            global::System.Func<global::G.ResponseFormatJsonSchema?, TResult>? jsonSchema = null,
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
            else if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsJsonObject && jsonObject != null)
            {
                return jsonObject(JsonObject!);
            }
            else if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.AssistantsApiResponseFormatOptionEnum?>? value1 = null,
            global::System.Action<global::G.ResponseFormatText?>? text = null,
            global::System.Action<global::G.ResponseFormatJsonObject?>? jsonObject = null,
            global::System.Action<global::G.ResponseFormatJsonSchema?>? jsonSchema = null,
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
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
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
                typeof(global::G.AssistantsApiResponseFormatOptionEnum),
                Text,
                typeof(global::G.ResponseFormatText),
                JsonObject,
                typeof(global::G.ResponseFormatJsonObject),
                JsonSchema,
                typeof(global::G.ResponseFormatJsonSchema),
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
                global::System.Collections.Generic.EqualityComparer<global::G.AssistantsApiResponseFormatOptionEnum?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatJsonObject?>.Default.Equals(JsonObject, other.JsonObject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatJsonSchema?>.Default.Equals(JsonSchema, other.JsonSchema) 
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
