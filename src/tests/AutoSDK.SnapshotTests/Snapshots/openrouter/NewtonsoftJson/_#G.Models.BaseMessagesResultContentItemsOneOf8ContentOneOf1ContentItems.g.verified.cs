//HintName: G.Models.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItems
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItems" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="type"></param>
        public BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItems(
            string fileId,
            global::G.BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItemsType type)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItems" /> class.
        /// </summary>
        public BaseMessagesResultContentItemsOneOf8ContentOneOf1ContentItems()
        {
        }
    }
}