//HintName: G.Models.UploadDatasetImageFromGenResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadDatasetImageFromGenResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadDatasetImageFromGen")]
        public global::G.UploadDatasetImageFromGenResponseUploadDatasetImageFromGen? UploadDatasetImageFromGen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageFromGenResponse" /> class.
        /// </summary>
        /// <param name="uploadDatasetImageFromGen"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UploadDatasetImageFromGenResponse(
            global::G.UploadDatasetImageFromGenResponseUploadDatasetImageFromGen? uploadDatasetImageFromGen)
        {
            this.UploadDatasetImageFromGen = uploadDatasetImageFromGen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDatasetImageFromGenResponse" /> class.
        /// </summary>
        public UploadDatasetImageFromGenResponse()
        {
        }
    }
}