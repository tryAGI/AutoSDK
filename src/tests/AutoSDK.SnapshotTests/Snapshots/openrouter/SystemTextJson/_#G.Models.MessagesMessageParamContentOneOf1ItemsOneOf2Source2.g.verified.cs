//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf2Source2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesMessageParamContentOneOf1ItemsOneOf2Source2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2TypeJsonConverter))]
        public global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2ContentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf2Source2" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentOneOf1ItemsOneOf2Source2(
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Content content,
            global::G.MessagesMessageParamContentOneOf1ItemsOneOf2SourceOneOf2Type type)
        {
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentOneOf1ItemsOneOf2Source2" /> class.
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf2Source2()
        {
        }
    }
}