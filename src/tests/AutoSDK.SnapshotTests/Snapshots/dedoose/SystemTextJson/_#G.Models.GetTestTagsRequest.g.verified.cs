//HintName: G.Models.GetTestTagsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTestTagsRequest
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
        /// Initializes a new instance of the <see cref="GetTestTagsRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="testId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTestTagsRequest(
            global::System.Guid projectId,
            global::System.Guid testId)
        {
            this.ProjectId = projectId;
            this.TestId = testId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestTagsRequest" /> class.
        /// </summary>
        public GetTestTagsRequest()
        {
        }
    }
}