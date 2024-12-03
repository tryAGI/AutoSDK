//HintName: G.Models.RemoveTagApplicationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RemoveTagApplicationRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("tagAppId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TagAppId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveTagApplicationRequest" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="tagAppId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RemoveTagApplicationRequest(
            global::System.Guid projectId,
            global::System.Guid tagAppId)
        {
            this.ProjectId = projectId;
            this.TagAppId = tagAppId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveTagApplicationRequest" /> class.
        /// </summary>
        public RemoveTagApplicationRequest()
        {
        }
    }
}