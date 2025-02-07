//HintName: G.Models.ProjectsCreateForOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsCreateForOrgRequest
    {
        /// <summary>
        /// The name of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateForOrgRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the project.
        /// </param>
        /// <param name="body">
        /// The description of the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectsCreateForOrgRequest(
            string name,
            string? body)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateForOrgRequest" /> class.
        /// </summary>
        public ProjectsCreateForOrgRequest()
        {
        }
    }
}