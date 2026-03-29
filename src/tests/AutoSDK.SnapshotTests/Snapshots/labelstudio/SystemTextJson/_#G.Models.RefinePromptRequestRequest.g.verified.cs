//HintName: G.Models.RefinePromptRequestRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RefinePromptRequestRequest
    {
        /// <summary>
        /// Project ID to target the refined prompt for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProjectId { get; set; }

        /// <summary>
        /// Name of the model to use to refine the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teacher_model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeacherModelName { get; set; }

        /// <summary>
        /// Model Provider Connection ID to use to refine the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teacher_model_provider_connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TeacherModelProviderConnectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RefinePromptRequestRequest" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Project ID to target the refined prompt for
        /// </param>
        /// <param name="teacherModelName">
        /// Name of the model to use to refine the prompt
        /// </param>
        /// <param name="teacherModelProviderConnectionId">
        /// Model Provider Connection ID to use to refine the prompt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RefinePromptRequestRequest(
            int projectId,
            string teacherModelName,
            int teacherModelProviderConnectionId)
        {
            this.ProjectId = projectId;
            this.TeacherModelName = teacherModelName ?? throw new global::System.ArgumentNullException(nameof(teacherModelName));
            this.TeacherModelProviderConnectionId = teacherModelProviderConnectionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RefinePromptRequestRequest" /> class.
        /// </summary>
        public RefinePromptRequestRequest()
        {
        }
    }
}