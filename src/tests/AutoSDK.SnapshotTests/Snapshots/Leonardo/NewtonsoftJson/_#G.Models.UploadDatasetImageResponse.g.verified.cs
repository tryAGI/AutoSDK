//HintName: G.Models.UploadDatasetImageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDatasetImageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploadDatasetImage")]
        public global::G.UploadDatasetImageResponseUploadDatasetImage? UploadDatasetImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageResponse" /> class.
        /// </summary>
        /// <param name="uploadDatasetImage"></param>
        public UploadDatasetImageResponse(
            global::G.UploadDatasetImageResponseUploadDatasetImage? uploadDatasetImage)
        {
            this.UploadDatasetImage = uploadDatasetImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageResponse" /> class.
        /// </summary>
        public UploadDatasetImageResponse()
        {
        }
    }
}