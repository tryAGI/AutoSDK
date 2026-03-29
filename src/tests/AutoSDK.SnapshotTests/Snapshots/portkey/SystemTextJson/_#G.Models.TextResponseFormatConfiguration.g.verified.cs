//HintName: G.Models.TextResponseFormatConfiguration.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An object specifying the format that the model must output.<br/>
    /// Configuring `{ "type": "json_schema" }` enables Structured Outputs, <br/>
    /// which ensures the model will match your supplied JSON schema. Learn more in the <br/>
    /// [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
    /// The default format is `{ "type": "text" }` with no additional options.<br/>
    /// **Not recommended for gpt-4o and newer models:**<br/>
    /// Setting to `{ "type": "json_object" }` enables the older JSON mode, which<br/>
    /// ensures the message the model generates is valid JSON. Using `json_schema`<br/>
    /// is preferred for models that support it.
    /// </summary>
    public readonly partial struct TextResponseFormatConfiguration : global::System.IEquatable<TextResponseFormatConfiguration>
    {
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
        /// JSON Schema response format. Used to generate structured JSON responses.<br/>
        /// Learn more about [Structured Outputs](/docs/guides/structured-outputs).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextResponseFormatJsonSchema? JsonSchema { get; init; }
#else
        public global::G.TextResponseFormatJsonSchema? JsonSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchema))]
#endif
        public bool IsJsonSchema => JsonSchema != null;

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
        /// 
        /// </summary>
        public static implicit operator TextResponseFormatConfiguration(global::G.ResponseFormatText value) => new TextResponseFormatConfiguration((global::G.ResponseFormatText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatText?(TextResponseFormatConfiguration @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public TextResponseFormatConfiguration(global::G.ResponseFormatText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextResponseFormatConfiguration(global::G.TextResponseFormatJsonSchema value) => new TextResponseFormatConfiguration((global::G.TextResponseFormatJsonSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextResponseFormatJsonSchema?(TextResponseFormatConfiguration @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public TextResponseFormatConfiguration(global::G.TextResponseFormatJsonSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextResponseFormatConfiguration(global::G.ResponseFormatJsonObject value) => new TextResponseFormatConfiguration((global::G.ResponseFormatJsonObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatJsonObject?(TextResponseFormatConfiguration @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public TextResponseFormatConfiguration(global::G.ResponseFormatJsonObject? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TextResponseFormatConfiguration(
            global::G.ResponseFormatText? text,
            global::G.TextResponseFormatJsonSchema? jsonSchema,
            global::G.ResponseFormatJsonObject? jsonObject
            )
        {
            Text = text;
            JsonSchema = jsonSchema;
            JsonObject = jsonObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonObject as object ??
            JsonSchema as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            JsonSchema?.ToString() ??
            JsonObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJsonSchema && !IsJsonObject || !IsText && IsJsonSchema && !IsJsonObject || !IsText && !IsJsonSchema && IsJsonObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseFormatText?, TResult>? text = null,
            global::System.Func<global::G.TextResponseFormatJsonSchema?, TResult>? jsonSchema = null,
            global::System.Func<global::G.ResponseFormatJsonObject?, TResult>? jsonObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }
            else if (IsJsonObject && jsonObject != null)
            {
                return jsonObject(JsonObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseFormatText?>? text = null,
            global::System.Action<global::G.TextResponseFormatJsonSchema?>? jsonSchema = null,
            global::System.Action<global::G.ResponseFormatJsonObject?>? jsonObject = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsJsonSchema)
            {
                jsonSchema?.Invoke(JsonSchema!);
            }
            else if (IsJsonObject)
            {
                jsonObject?.Invoke(JsonObject!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::G.ResponseFormatText),
                JsonSchema,
                typeof(global::G.TextResponseFormatJsonSchema),
                JsonObject,
                typeof(global::G.ResponseFormatJsonObject),
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
        public bool Equals(TextResponseFormatConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextResponseFormatJsonSchema?>.Default.Equals(JsonSchema, other.JsonSchema) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatJsonObject?>.Default.Equals(JsonObject, other.JsonObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextResponseFormatConfiguration obj1, TextResponseFormatConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextResponseFormatConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextResponseFormatConfiguration obj1, TextResponseFormatConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextResponseFormatConfiguration o && Equals(o);
        }
    }
}
