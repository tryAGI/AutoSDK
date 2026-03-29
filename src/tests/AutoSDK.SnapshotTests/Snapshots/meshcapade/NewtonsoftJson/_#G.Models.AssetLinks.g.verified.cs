//HintName: G.Models.AssetLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssetLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self")]
        public string? Self { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_upload")]
        public string? ImageUpload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetLinks" /> class.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="imageUpload"></param>
        public AssetLinks(
            string? self,
            string? imageUpload)
        {
            this.Self = self;
            this.ImageUpload = imageUpload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetLinks" /> class.
        /// </summary>
        public AssetLinks()
        {
        }
    }
}