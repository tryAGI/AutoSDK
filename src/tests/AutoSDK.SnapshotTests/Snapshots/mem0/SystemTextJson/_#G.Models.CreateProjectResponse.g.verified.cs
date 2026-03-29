//HintName: G.Models.CreateProjectResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectResponse
    {
        /// <summary>
        /// Example: Project created successfully.
        /// </summary>
        /// <example>Project created successfully.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Unique identifier for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// Example: Project created successfully.
        /// </param>
        /// <param name="projectId">
        /// Unique identifier for the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectResponse(
            string? message,
            global::System.Guid? projectId)
        {
            this.Message = message;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectResponse" /> class.
        /// </summary>
        public CreateProjectResponse()
        {
        }
    }
}