//HintName: G.Models.GetTestExcerptsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTestExcerptsRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestExcerptsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="testId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetTestExcerptsRequest(
            global::System.Guid projectId,
            global::System.Guid testId)
        {
            this.ProjectId = projectId;
            this.TestId = testId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestExcerptsRequest" /> class.
        /// </summary>
        public GetTestExcerptsRequest()
        {
        }
    }
}