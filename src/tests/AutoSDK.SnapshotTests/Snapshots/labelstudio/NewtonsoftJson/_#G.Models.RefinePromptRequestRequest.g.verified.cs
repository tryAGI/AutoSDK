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
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProjectId { get; set; } = default!;

        /// <summary>
        /// Name of the model to use to refine the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teacher_model_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string TeacherModelName { get; set; } = default!;

        /// <summary>
        /// Model Provider Connection ID to use to refine the prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("teacher_model_provider_connection_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int TeacherModelProviderConnectionId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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