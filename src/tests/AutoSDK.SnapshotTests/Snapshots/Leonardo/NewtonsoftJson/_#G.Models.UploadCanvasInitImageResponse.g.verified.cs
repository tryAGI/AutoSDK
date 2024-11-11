//HintName: G.Models.UploadCanvasInitImageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadCanvasInitImageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploadCanvasInitImage")]
        public global::G.UploadCanvasInitImageResponseUploadCanvasInitImage? UploadCanvasInitImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCanvasInitImageResponse" /> class.
        /// </summary>
        /// <param name="uploadCanvasInitImage"></param>
        public UploadCanvasInitImageResponse(
            global::G.UploadCanvasInitImageResponseUploadCanvasInitImage? uploadCanvasInitImage)
        {
            this.UploadCanvasInitImage = uploadCanvasInitImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadCanvasInitImageResponse" /> class.
        /// </summary>
        public UploadCanvasInitImageResponse()
        {
        }
    }
}