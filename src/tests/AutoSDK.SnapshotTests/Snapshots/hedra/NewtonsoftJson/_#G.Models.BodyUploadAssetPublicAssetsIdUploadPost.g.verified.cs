//HintName: G.Models.BodyUploadAssetPublicAssetsIdUploadPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadAssetPublicAssetsIdUploadPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public string File { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadAssetPublicAssetsIdUploadPost" /> class.
        /// </summary>
        /// <param name="file"></param>
        public BodyUploadAssetPublicAssetsIdUploadPost(
            string file)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadAssetPublicAssetsIdUploadPost" /> class.
        /// </summary>
        public BodyUploadAssetPublicAssetsIdUploadPost()
        {
        }
    }
}