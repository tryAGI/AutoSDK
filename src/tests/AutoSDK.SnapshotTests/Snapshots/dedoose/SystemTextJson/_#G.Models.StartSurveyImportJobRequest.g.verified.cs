//HintName: G.Models.StartSurveyImportJobRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StartSurveyImportJobRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("surveyUploadedFileURL")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SurveyUploadedFileURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encryptedSymKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedSymKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartSurveyImportJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="surveyUploadedFileURL"></param>
        /// <param name="encryptedSymKey"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StartSurveyImportJobRequest(
            global::System.Guid projectId,
            string surveyUploadedFileURL,
            string encryptedSymKey)
        {
            this.ProjectId = projectId;
            this.SurveyUploadedFileURL = surveyUploadedFileURL ?? throw new global::System.ArgumentNullException(nameof(surveyUploadedFileURL));
            this.EncryptedSymKey = encryptedSymKey ?? throw new global::System.ArgumentNullException(nameof(encryptedSymKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StartSurveyImportJobRequest" /> class.
        /// </summary>
        public StartSurveyImportJobRequest()
        {
        }
    }
}