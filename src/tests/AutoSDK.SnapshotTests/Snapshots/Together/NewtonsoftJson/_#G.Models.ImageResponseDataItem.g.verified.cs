//HintName: G.Models.ImageResponseDataItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("b64_json", Required = global::Newtonsoft.Json.Required.Always)]
        public string B64Json { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResponseDataItem" /> class.
        /// </summary>
        /// <param name="b64Json"></param>
        /// <param name="index"></param>
        public ImageResponseDataItem(
            string b64Json,
            int index)
        {
            this.B64Json = b64Json ?? throw new global::System.ArgumentNullException(nameof(b64Json));
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResponseDataItem" /> class.
        /// </summary>
        public ImageResponseDataItem()
        {
        }
    }
}