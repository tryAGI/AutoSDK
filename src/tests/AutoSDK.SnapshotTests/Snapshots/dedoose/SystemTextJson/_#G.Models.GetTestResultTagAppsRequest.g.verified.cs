//HintName: G.Models.GetTestResultTagAppsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTestResultTagAppsRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("testId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testResultId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TestResultId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestResultTagAppsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="testId"></param>
        /// <param name="testResultId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTestResultTagAppsRequest(
            global::System.Guid projectId,
            global::System.Guid testId,
            global::System.Guid testResultId)
        {
            this.ProjectId = projectId;
            this.TestId = testId;
            this.TestResultId = testResultId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestResultTagAppsRequest" /> class.
        /// </summary>
        public GetTestResultTagAppsRequest()
        {
        }
    }
}