//HintName: G.Models.ProjectsCreateForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsCreateForAuthenticatedUserRequest
    {
        /// <summary>
        /// Name of the project<br/>
        /// Example: Week One Sprint
        /// </summary>
        /// <example>Week One Sprint</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Body of the project<br/>
        /// Example: This project represents the sprint of the first week in January
        /// </summary>
        /// <example>This project represents the sprint of the first week in January</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project<br/>
        /// Example: Week One Sprint
        /// </param>
        /// <param name="body">
        /// Body of the project<br/>
        /// Example: This project represents the sprint of the first week in January
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsCreateForAuthenticatedUserRequest(
            string name,
            string? body)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateForAuthenticatedUserRequest" /> class.
        /// </summary>
        public ProjectsCreateForAuthenticatedUserRequest()
        {
        }
    }
}