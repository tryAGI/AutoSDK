//HintName: G.Models.CreateSearchResponseImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSearchResponseImage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchResponseImage" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="description"></param>
        public CreateSearchResponseImage(
            string? url,
            string? description)
        {
            this.Url = url;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSearchResponseImage" /> class.
        /// </summary>
        public CreateSearchResponseImage()
        {
        }
    }
}