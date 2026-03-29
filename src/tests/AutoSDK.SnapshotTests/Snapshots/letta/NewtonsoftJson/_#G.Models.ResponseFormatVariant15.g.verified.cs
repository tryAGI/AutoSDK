//HintName: G.Models.ResponseFormatVariant15.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponseFormatVariant15 : global::System.IEquatable<ResponseFormatVariant15>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.CreateAgentRequestResponseFormatVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// Response format for plain text responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextResponseFormat? Text { get; init; }
#else
        public global::G.TextResponseFormat? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// Response format for JSON schema-based responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.JsonSchemaResponseFormat? JsonSchema { get; init; }
#else
        public global::G.JsonSchemaResponseFormat? JsonSchema { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JsonSchema))]
#endif
        public bool IsJsonSchema => JsonSchema != null;

        /// <summary>
        /// Response format for JSON object responses.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.JsonObjectResponseFormat? JsonObject { get; init; }
#else
        public global::G.JsonObjectResponseFormat? JsonObject { get; }
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
        public static implicit operator ResponseFormatVariant15(global::G.TextResponseFormat value) => new ResponseFormatVariant15((global::G.TextResponseFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextResponseFormat?(ResponseFormatVariant15 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatVariant15(global::G.TextResponseFormat? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatVariant15(global::G.JsonSchemaResponseFormat value) => new ResponseFormatVariant15((global::G.JsonSchemaResponseFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.JsonSchemaResponseFormat?(ResponseFormatVariant15 @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatVariant15(global::G.JsonSchemaResponseFormat? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormatVariant15(global::G.JsonObjectResponseFormat value) => new ResponseFormatVariant15((global::G.JsonObjectResponseFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.JsonObjectResponseFormat?(ResponseFormatVariant15 @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatVariant15(global::G.JsonObjectResponseFormat? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatVariant15(
            global::G.CreateAgentRequestResponseFormatVariant1DiscriminatorType? type,
            global::G.TextResponseFormat? text,
            global::G.JsonSchemaResponseFormat? jsonSchema,
            global::G.JsonObjectResponseFormat? jsonObject
            )
        {
            Type = type;

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
            global::System.Func<global::G.TextResponseFormat?, TResult>? text = null,
            global::System.Func<global::G.JsonSchemaResponseFormat?, TResult>? jsonSchema = null,
            global::System.Func<global::G.JsonObjectResponseFormat?, TResult>? jsonObject = null,
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
            global::System.Action<global::G.TextResponseFormat?>? text = null,
            global::System.Action<global::G.JsonSchemaResponseFormat?>? jsonSchema = null,
            global::System.Action<global::G.JsonObjectResponseFormat?>? jsonObject = null,
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
                typeof(global::G.TextResponseFormat),
                JsonSchema,
                typeof(global::G.JsonSchemaResponseFormat),
                JsonObject,
                typeof(global::G.JsonObjectResponseFormat),
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
        public bool Equals(ResponseFormatVariant15 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextResponseFormat?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.JsonSchemaResponseFormat?>.Default.Equals(JsonSchema, other.JsonSchema) &&
                global::System.Collections.Generic.EqualityComparer<global::G.JsonObjectResponseFormat?>.Default.Equals(JsonObject, other.JsonObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormatVariant15 obj1, ResponseFormatVariant15 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormatVariant15>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormatVariant15 obj1, ResponseFormatVariant15 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormatVariant15 o && Equals(o);
        }
    }
}
