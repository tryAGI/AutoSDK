//HintName: G.Models.CloneDocumentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CloneDocumentRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloneExcerpts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CloneExcerpts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloneTagApps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CloneTagApps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDocumentRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="resourceId"></param>
        /// <param name="cloneExcerpts"></param>
        /// <param name="cloneTagApps"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CloneDocumentRequest(
            global::System.Guid projectId,
            global::System.Guid resourceId,
            bool cloneExcerpts,
            bool cloneTagApps)
        {
            this.ProjectId = projectId;
            this.ResourceId = resourceId;
            this.CloneExcerpts = cloneExcerpts;
            this.CloneTagApps = cloneTagApps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloneDocumentRequest" /> class.
        /// </summary>
        public CloneDocumentRequest()
        {
        }
    }
}