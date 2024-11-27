//HintName: G.Models.StartExportTestResultJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartExportTestResultJobRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projectId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testResultId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TestResultId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileExtension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileExtension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cryptoKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CryptoKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportTestResultJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="testResultId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="cryptoKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartExportTestResultJobRequest(
            global::System.Guid projectId,
            global::System.Guid testResultId,
            string fileExtension,
            string cryptoKey)
        {
            this.ProjectId = projectId;
            this.TestResultId = testResultId;
            this.FileExtension = fileExtension ?? throw new global::System.ArgumentNullException(nameof(fileExtension));
            this.CryptoKey = cryptoKey ?? throw new global::System.ArgumentNullException(nameof(cryptoKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportTestResultJobRequest" /> class.
        /// </summary>
        public StartExportTestResultJobRequest()
        {
        }
    }
}