//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf8Content1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1ItemsOneOf8Content1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1TypeJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf8Content1" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentOneOf1ItemsOneOf8Content1(
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1ErrorCode errorCode,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf8ContentOneOf1Type type)
        {
            this.Type = type;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf8Content1" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf8Content1()
        {
        }
    }
}