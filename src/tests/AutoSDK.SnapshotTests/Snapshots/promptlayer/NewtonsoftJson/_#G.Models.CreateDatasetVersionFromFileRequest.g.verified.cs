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
        [global::Newtonsoft.Json.JsonProperty("dataset_group_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int DatasetGroupId { get; set; } = default!;

        /// <summary>
        /// Name of the file being uploaded (must end with .csv or .json)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileName { get; set; } = default!;

        /// <summary>
        /// Base64 encoded content of the file. Maximum file size: 100MB. Supported formats: CSV, JSON
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_content_base64", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileContentBase64 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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