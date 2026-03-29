//HintName: G.Models.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsTypeJsonConverter))]
        public global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems(
            string fileId,
            global::G.BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItemsType type)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf7ContentOneOf2ContentItems()
        {
        }
    }
}