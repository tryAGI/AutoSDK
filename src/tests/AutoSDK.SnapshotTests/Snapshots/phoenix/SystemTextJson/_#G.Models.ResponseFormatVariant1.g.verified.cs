//HintName: G.Models.ResponseFormatVariant1.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponseFormatVariant1 : global::System.IEquatable<ResponseFormatVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.PromptVersionResponseFormatVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PromptResponseFormatJSONSchema? JsonSchema { get; init; }
#else
        public global::G.PromptResponseFormatJSONSchema? JsonSchema { get; }
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
        public static implicit operator ResponseFormatVariant1(global::G.PromptResponseFormatJSONSchema value) => new ResponseFormatVariant1((global::G.PromptResponseFormatJSONSchema?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PromptResponseFormatJSONSchema?(ResponseFormatVariant1 @this) => @this.JsonSchema;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatVariant1(global::G.PromptResponseFormatJSONSchema? value)
        {
            JsonSchema = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatVariant1(
            global::G.PromptVersionResponseFormatVariant1DiscriminatorType? type,
            global::G.PromptResponseFormatJSONSchema? jsonSchema
            )
        {
            Type = type;

            JsonSchema = jsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonSchema as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            JsonSchema?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsJsonSchema;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.PromptResponseFormatJSONSchema?, TResult>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonSchema && jsonSchema != null)
            {
                return jsonSchema(JsonSchema!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.PromptResponseFormatJSONSchema?>? jsonSchema = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsJsonSchema)
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
                JsonSchema,
                typeof(global::G.PromptResponseFormatJSONSchema),
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
        public bool Equals(ResponseFormatVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.PromptResponseFormatJSONSchema?>.Default.Equals(JsonSchema, other.JsonSchema) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormatVariant1 obj1, ResponseFormatVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormatVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormatVariant1 obj1, ResponseFormatVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormatVariant1 o && Equals(o);
        }
    }
}
