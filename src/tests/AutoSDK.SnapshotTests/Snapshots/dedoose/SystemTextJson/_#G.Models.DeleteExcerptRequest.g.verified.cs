//HintName: G.Models.DeleteExcerptRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteExcerptRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("excerptId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid ExcerptId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteExcerptRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="excerptId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteExcerptRequest(
            global::System.Guid projectId,
            global::System.Guid excerptId)
        {
            this.ProjectId = projectId;
            this.ExcerptId = excerptId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteExcerptRequest" /> class.
        /// </summary>
        public DeleteExcerptRequest()
        {
        }
    }
}