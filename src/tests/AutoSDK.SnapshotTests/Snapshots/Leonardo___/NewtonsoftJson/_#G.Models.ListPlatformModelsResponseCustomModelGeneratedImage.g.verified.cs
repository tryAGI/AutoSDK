//HintName: G.Models.ListPlatformModelsResponseCustomModelGeneratedImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// columns and relationships of "generated_images"
    /// </summary>
    public sealed partial class ListPlatformModelsResponseCustomModelGeneratedImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPlatformModelsResponseCustomModelGeneratedImage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        public ListPlatformModelsResponseCustomModelGeneratedImage(
            string? id,
            string? url)
        {
            this.Id = id;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPlatformModelsResponseCustomModelGeneratedImage" /> class.
        /// </summary>
        public ListPlatformModelsResponseCustomModelGeneratedImage()
        {
        }
    }
}