//HintName: G.Models.ImageResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageResult
    {
        /// <summary>
        /// Image index.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// URL of the generated image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResult" /> class.
        /// </summary>
        /// <param name="index">
        /// Image index.
        /// </param>
        /// <param name="url">
        /// URL of the generated image.
        /// </param>
        public ImageResult(
            int? index,
            string? url)
        {
            this.Index = index;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResult" /> class.
        /// </summary>
        public ImageResult()
        {
        }
    }
}