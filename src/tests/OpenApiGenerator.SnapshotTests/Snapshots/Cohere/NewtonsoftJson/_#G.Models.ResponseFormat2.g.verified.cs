//HintName: G.Models.ResponseFormat2.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for forcing the model output to adhere to the specified format. Supported on [Command R](https://docs.cohere.com/docs/command-r), [Command R+](https://docs.cohere.com/docs/command-r-plus) and newer models.<br/>
    /// The model can be forced into outputting JSON objects (with up to 5 levels of nesting) by setting `{ "type": "json_object" }`.<br/>
    /// A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.<br/>
    /// **Note**: When using  `{ "type": "json_object" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _"Generate a JSON ..."_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.<br/>
    /// **Limitation**: The parameter is not supported in RAG mode (when any of `connectors`, `documents`, `tools`, `tool_results` are provided).
    /// </summary>
    public readonly partial struct ResponseFormat2 : global::System.IEquatable<ResponseFormat2>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextResponseFormat? TextFormat { get; init; }
#else
        public global::G.TextResponseFormat? TextFormat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextFormat))]
#endif
        public bool IsTextFormat => TextFormat != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormat2(global::G.TextResponseFormat value) => new ResponseFormat2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextResponseFormat?(ResponseFormat2 @this) => @this.TextFormat;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat2(global::G.TextResponseFormat? value)
        {
            TextFormat = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.JSONResponseFormat2? JSON { get; init; }
#else
        public global::G.JSONResponseFormat2? JSON { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(JSON))]
#endif
        public bool IsJSON => JSON != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponseFormat2(global::G.JSONResponseFormat2 value) => new ResponseFormat2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.JSONResponseFormat2?(ResponseFormat2 @this) => @this.JSON;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat2(global::G.JSONResponseFormat2? value)
        {
            JSON = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormat2(
            global::G.TextResponseFormat? textFormat,
            global::G.JSONResponseFormat2? jSON
            )
        {
            TextFormat = textFormat;
            JSON = jSON;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            JSON as object ??
            TextFormat as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextFormat && !IsJSON || !IsTextFormat && IsJSON;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextFormat,
                typeof(global::G.TextResponseFormat),
                JSON,
                typeof(global::G.JSONResponseFormat2),
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
        public bool Equals(ResponseFormat2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextResponseFormat?>.Default.Equals(TextFormat, other.TextFormat) &&
                global::System.Collections.Generic.EqualityComparer<global::G.JSONResponseFormat2?>.Default.Equals(JSON, other.JSON) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormat2 obj1, ResponseFormat2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormat2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormat2 obj1, ResponseFormat2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormat2 o && Equals(o);
        }
    }
}
