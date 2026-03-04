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
        public global::G.TextResponseFormatJsonSchema? JSONSchema { get; init; }
#else
        public global::G.TextResponseFormatJsonSchema? JSONSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JSONSchema))]
#endif
        public bool IsJSONSchema => JSONSchema != null;

        /// <summary>
        /// JSON object response format. An older method of generating JSON responses.<br/>
        /// Using `json_schema` is recommended for models that support it. Note that the<br/>
        /// model will not generate JSON without a system or user message instructing it<br/>
        /// to do so.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ResponseFormatJsonObject? JSONObject { get; init; }
#else
        public global::G.ResponseFormatJsonObject? JSONObject { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JSONObject))]
#endif
        public bool IsJSONObject => JSONObject != null;
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
        public static implicit operator global::G.TextResponseFormatJsonSchema?(TextResponseFormatConfiguration @this) => @this.JSONSchema;

        /// <summary>
        /// 
        /// </summary>
        public TextResponseFormatConfiguration(global::G.TextResponseFormatJsonSchema? value)
        {
            JSONSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextResponseFormatConfiguration(global::G.ResponseFormatJsonObject value) => new TextResponseFormatConfiguration((global::G.ResponseFormatJsonObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatJsonObject?(TextResponseFormatConfiguration @this) => @this.JSONObject;

        /// <summary>
        /// 
        /// </summary>
        public TextResponseFormatConfiguration(global::G.ResponseFormatJsonObject? value)
        {
            JSONObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TextResponseFormatConfiguration(
            global::G.ResponseFormatText? text,
            global::G.TextResponseFormatJsonSchema? jSONSchema,
            global::G.ResponseFormatJsonObject? jSONObject
            )
        {
            Text = text;
            JSONSchema = jSONSchema;
            JSONObject = jSONObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JSONObject as object ??
            JSONSchema as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            JSONSchema?.ToString() ??
            JSONObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJSONSchema && !IsJSONObject || !IsText && IsJSONSchema && !IsJSONObject || !IsText && !IsJSONSchema && IsJSONObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseFormatText?, TResult>? text = null,
            global::System.Func<global::G.TextResponseFormatJsonSchema?, TResult>? jSONSchema = null,
            global::System.Func<global::G.ResponseFormatJsonObject?, TResult>? jSONObject = null,
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
            else if (IsJSONSchema && jSONSchema != null)
            {
                return jSONSchema(JSONSchema!);
            }
            else if (IsJSONObject && jSONObject != null)
            {
                return jSONObject(JSONObject!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ResponseFormatText?>? text = null,
            global::System.Action<global::G.TextResponseFormatJsonSchema?>? jSONSchema = null,
            global::System.Action<global::G.ResponseFormatJsonObject?>? jSONObject = null,
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
            else if (IsJSONSchema)
            {
                jSONSchema?.Invoke(JSONSchema!);
            }
            else if (IsJSONObject)
            {
                jSONObject?.Invoke(JSONObject!);
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
                JSONSchema,
                typeof(global::G.TextResponseFormatJsonSchema),
                JSONObject,
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
                global::System.Collections.Generic.EqualityComparer<global::G.TextResponseFormatJsonSchema?>.Default.Equals(JSONSchema, other.JSONSchema) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatJsonObject?>.Default.Equals(JSONObject, other.JSONObject) 
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
