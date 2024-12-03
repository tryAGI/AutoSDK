//HintName: G.Models.UploadInitImageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadInitImageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadInitImage")]
        public global::G.UploadInitImageResponseUploadInitImage? UploadInitImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadInitImageResponse" /> class.
        /// </summary>
        /// <param name="uploadInitImage"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UploadInitImageResponse(
            global::G.UploadInitImageResponseUploadInitImage? uploadInitImage)
        {
            this.UploadInitImage = uploadInitImage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadInitImageResponse" /> class.
        /// </summary>
        public UploadInitImageResponse()
        {
        }
    }
}