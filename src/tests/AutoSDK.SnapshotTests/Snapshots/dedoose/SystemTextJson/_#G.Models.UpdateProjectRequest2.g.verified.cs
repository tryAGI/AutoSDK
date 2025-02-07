//HintName: G.Models.UpdateProjectRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateProjectRequest2
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
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedTitle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedDescription")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest2" /> class.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="updatedTitle"></param>
        /// <param name="updatedDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectRequest2(
            global::System.Guid projectId,
            string updatedTitle,
            string updatedDescription)
        {
            this.ProjectId = projectId;
            this.UpdatedTitle = updatedTitle ?? throw new global::System.ArgumentNullException(nameof(updatedTitle));
            this.UpdatedDescription = updatedDescription ?? throw new global::System.ArgumentNullException(nameof(updatedDescription));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectRequest2" /> class.
        /// </summary>
        public UpdateProjectRequest2()
        {
        }
    }
}