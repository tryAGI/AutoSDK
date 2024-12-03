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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("testResultId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TestResultId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileExtension", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileExtension { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cryptoKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string CryptoKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StartExportTestResultJobRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="testResultId"></param>
        /// <param name="fileExtension"></param>
        /// <param name="cryptoKey"></param>
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