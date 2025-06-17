﻿//HintName: G.Models.ResponseFormatV2.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for forcing the model output to adhere to the specified format. Supported on [Command R](https://docs.cohere.com/v2/docs/command-r), [Command R+](https://docs.cohere.com/v2/docs/command-r-plus) and newer models.<br/>
    /// The model can be forced into outputting JSON objects by setting `{ "type": "json_object" }`.<br/>
    /// A [JSON Schema](https://json-schema.org/) can optionally be provided, to ensure a specific structure.<br/>
    /// **Note**: When using  `{ "type": "json_object" }` your `message` should always explicitly instruct the model to generate a JSON (eg: _"Generate a JSON ..."_) . Otherwise the model may end up getting stuck generating an infinite stream of characters and eventually run out of context length.<br/>
    /// **Note**: When `json_schema` is not specified, the generated object can have up to 5 layers of nesting.<br/>
    /// **Limitation**: The parameter is not supported when used in combinations with the `documents` or `tools` parameters.
    /// </summary>
    public readonly partial struct ResponseFormatV2 : global::System.IEquatable<ResponseFormatV2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.ResponseFormatV2DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.TextResponseFormatV2? Text { get; init; }
#else
        public global::G.TextResponseFormatV2? Text { get; }
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
        public static implicit operator ResponseFormatV2(global::G.TextResponseFormatV2 value) => new ResponseFormatV2((global::G.TextResponseFormatV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.TextResponseFormatV2?(ResponseFormatV2 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatV2(global::G.TextResponseFormatV2? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.JsonResponseFormatV2? JsonObject { get; init; }
#else
        public global::G.JsonResponseFormatV2? JsonObject { get; }
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
        public static implicit operator ResponseFormatV2(global::G.JsonResponseFormatV2 value) => new ResponseFormatV2((global::G.JsonResponseFormatV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.JsonResponseFormatV2?(ResponseFormatV2 @this) => @this.JsonObject;

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatV2(global::G.JsonResponseFormatV2? value)
        {
            JsonObject = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ResponseFormatV2(
            global::G.ResponseFormatV2DiscriminatorType? type,
            global::G.TextResponseFormatV2? text,
            global::G.JsonResponseFormatV2? jsonObject
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
            global::System.Func<global::G.TextResponseFormatV2?, TResult>? text = null,
            global::System.Func<global::G.JsonResponseFormatV2?, TResult>? jsonObject = null,
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
            global::System.Action<global::G.TextResponseFormatV2?>? text = null,
            global::System.Action<global::G.JsonResponseFormatV2?>? jsonObject = null,
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
                typeof(global::G.TextResponseFormatV2),
                JsonObject,
                typeof(global::G.JsonResponseFormatV2),
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
        public bool Equals(ResponseFormatV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.TextResponseFormatV2?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::G.JsonResponseFormatV2?>.Default.Equals(JsonObject, other.JsonObject) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponseFormatV2 obj1, ResponseFormatV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseFormatV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponseFormatV2 obj1, ResponseFormatV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseFormatV2 o && Equals(o);
        }
    }
}
