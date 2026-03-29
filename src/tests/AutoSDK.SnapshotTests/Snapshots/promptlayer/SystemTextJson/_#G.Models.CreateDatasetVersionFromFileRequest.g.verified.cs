//HintName: G.Models.CreateDatasetVersionFromFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDatasetVersionFromFileRequest
    {
        /// <summary>
        /// ID of the dataset group where the new version will be created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DatasetGroupId { get; set; }

        /// <summary>
        /// Name of the file being uploaded (must end with .csv or .json)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// Base64 encoded content of the file. Maximum file size: 100MB. Supported formats: CSV, JSON
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_content_base64")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileContentBase64 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFileRequest" /> class.
        /// </summary>
        /// <param name="datasetGroupId">
        /// ID of the dataset group where the new version will be created
        /// </param>
        /// <param name="fileName">
        /// Name of the file being uploaded (must end with .csv or .json)
        /// </param>
        /// <param name="fileContentBase64">
        /// Base64 encoded content of the file. Maximum file size: 100MB. Supported formats: CSV, JSON
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDatasetVersionFromFileRequest(
            int datasetGroupId,
            string fileName,
            string fileContentBase64)
        {
            this.DatasetGroupId = datasetGroupId;
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.FileContentBase64 = fileContentBase64 ?? throw new global::System.ArgumentNullException(nameof(fileContentBase64));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDatasetVersionFromFileRequest" /> class.
        /// </summary>
        public CreateDatasetVersionFromFileRequest()
        {
        }
    }
}