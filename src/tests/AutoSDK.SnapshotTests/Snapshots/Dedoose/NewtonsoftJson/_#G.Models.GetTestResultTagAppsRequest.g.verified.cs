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
        [global::Newtonsoft.Json.JsonProperty("projectId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid ProjectId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("testId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("testResultId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid TestResultId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestResultTagAppsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="testId"></param>
        /// <param name="testResultId"></param>
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