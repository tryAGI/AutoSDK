//HintName: G.Models.VectorStoreFileContentResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreFileContentResponseDataItem
    {
        /// <summary>
        /// The text content
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The content type (currently only `"text"`)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileContentResponseDataItem" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content
        /// </param>
        /// <param name="type">
        /// The content type (currently only `"text"`)
        /// </param>
        public VectorStoreFileContentResponseDataItem(
            string? text,
            string? type)
        {
            this.Text = text;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileContentResponseDataItem" /> class.
        /// </summary>
        public VectorStoreFileContentResponseDataItem()
        {
        }
    }
}