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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("surveyUploadedFileURL", Required = global::Newtonsoft.Json.Required.Always)]
        public string SurveyUploadedFileURL { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encryptedSymKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string EncryptedSymKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartSurveyImportJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="surveyUploadedFileURL"></param>
        /// <param name="encryptedSymKey"></param>
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