//HintName: G.Models.ResponseFormat.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for forcing the model output to adhere to the specified format. Supported on [Command R 03-2024](https://docs.cohere.com/docs/command-r), [Command R+ 04-2024](https://docs.cohere.com/docs/command-r-plus) and newer models.<br/>
    /// The model can be forced into outputting JSON objects (with up to 5 levels of nesting) by setting `{ "type": "json_object" }`.<br/>
    /// A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.<br/>
    /// **Note**: When using  `{ "type": "json_object" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _"Generate a JSON ..."_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.<br/>
    /// **Limitation**: The parameter is not supported in RAG mode (when any of `connectors`, `documents`, `tools`, `tool_results` are provided).
    /// </summary>
    public readonly partial struct ResponseFormat : global::System.IEquatable<ResponseFormat>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFormatDiscriminatorType? Type { get; }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        public static implicit operator ResponseFormat(global::G.TextResponseFormat value) => new ResponseFormat((global::G.TextResponseFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextResponseFormat?(ResponseFormat @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat(global::G.TextResponseFormat? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.JSONResponseFormat? JsonObject { get; init; }
#else
        public global::G.JSONResponseFormat? JsonObject { get; }
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
        public static implicit operator ResponseFormat(global::G.JSONResponseFormat value) => new ResponseFormat((global::G.JSONResponseFormat?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.JSONResponseFormat?(ResponseFormat @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat(global::G.JSONResponseFormat? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat(
            global::G.ResponseFormatDiscriminatorType? type,
            global::G.TextResponseFormat? text,
            global::G.JSONResponseFormat? jsonObject
            )
        {
            Type = type;

            Text = text;
            JsonObject = jsonObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JsonObject as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            JsonObject?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsJsonObject || !IsText && IsJsonObject;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.TextResponseFormat?, TResult>? text = null,
            global::System.Func<global::G.JSONResponseFormat?, TResult>? jsonObject = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.TextResponseFormat?>? text = null,
            global::System.Action<global::G.JSONResponseFormat?>? jsonObject = null,
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
                JsonObject,
                typeof(global::G.JSONResponseFormat),
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
        public bool Equals(ResponseFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextResponseFormat?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.JSONResponseFormat?>.Default.Equals(JsonObject, other.JsonObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormat obj1, ResponseFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormat obj1, ResponseFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormat o && Equals(o);
        }
    }
}
