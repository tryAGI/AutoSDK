//HintName: G.Models.UploadFileResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadFileResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_token", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileResponseData" /> class.
        /// </summary>
        /// <param name="imageToken"></param>
        public UploadFileResponseData(
            string imageToken)
        {
            this.ImageToken = imageToken ?? throw new global::System.ArgumentNullException(nameof(imageToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileResponseData" /> class.
        /// </summary>
        public UploadFileResponseData()
        {
        }
    }
}