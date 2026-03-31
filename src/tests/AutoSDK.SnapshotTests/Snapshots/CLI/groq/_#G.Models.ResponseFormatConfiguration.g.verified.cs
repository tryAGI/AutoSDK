//HintName: G.Models.ResponseFormatConfiguration.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// An object specifying the format that the model must output.
    /// </summary>
    public readonly partial struct ResponseFormatConfiguration : global::System.IEquatable<ResponseFormatConfiguration>
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
        /// JSON object response format. An older method of generating JSON responses. Using `json_schema` is recommended for models that support it. Note that the model will not generate JSON without a system or user message instructing it to do so.
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
        /// JSON Schema response format. Used to generate structured JSON responses.
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
        /// 
        /// </summary>
        public static implicit operator ResponseFormatConfiguration(global::G.ResponseFormatText value) => new ResponseFormatConfiguration((global::G.ResponseFormatText?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatText?(ResponseFormatConfiguration @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatConfiguration(global::G.ResponseFormatText? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatConfiguration(global::G.ResponseFormatJsonObject value) => new ResponseFormatConfiguration((global::G.ResponseFormatJsonObject?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ResponseFormatJsonObject?(ResponseFormatConfiguration @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatConfiguration(global::G.ResponseFormatJsonObject? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatConfiguration(global::G.TextResponseFormatJsonSchema value) => new ResponseFormatConfiguration((global::G.TextResponseFormatJsonSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextResponseFormatJsonSchema?(ResponseFormatConfiguration @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatConfiguration(global::G.TextResponseFormatJsonSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatConfiguration(
            global::G.ResponseFormatText? text,
            global::G.ResponseFormatJsonObject? jsonObject,
            global::G.TextResponseFormatJsonSchema? jsonSchema
            )
        {
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
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            JsonObject?.ToString() ??
            JsonSchema?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJsonObject && !IsJsonSchema || !IsText && IsJsonObject && !IsJsonSchema || !IsText && !IsJsonObject && IsJsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ResponseFormatText?, TResult>? text = null,
            global::System.Func<global::G.ResponseFormatJsonObject?, TResult>? jsonObject = null,
            global::System.Func<global::G.TextResponseFormatJsonSchema?, TResult>? jsonSchema = null,
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
            global::System.Action<global::G.ResponseFormatText?>? text = null,
            global::System.Action<global::G.ResponseFormatJsonObject?>? jsonObject = null,
            global::System.Action<global::G.TextResponseFormatJsonSchema?>? jsonSchema = null,
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
                Text,
                typeof(global::G.ResponseFormatText),
                JsonObject,
                typeof(global::G.ResponseFormatJsonObject),
                JsonSchema,
                typeof(global::G.TextResponseFormatJsonSchema),
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
        public bool Equals(ResponseFormatConfiguration other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatText?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ResponseFormatJsonObject?>.Default.Equals(JsonObject, other.JsonObject) &&
                global::System.Collections.Generic.EqualityComparer<global::G.TextResponseFormatJsonSchema?>.Default.Equals(JsonSchema, other.JsonSchema) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormatConfiguration obj1, ResponseFormatConfiguration obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormatConfiguration>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormatConfiguration obj1, ResponseFormatConfiguration obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormatConfiguration o && Equals(o);
        }
    }
}
