//HintName: G.Models.ProjectsCreateForRepoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsCreateForRepoRequest
    {
        /// <summary>
        /// The name of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The description of the project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("body")]
        public string? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateForRepoRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the project.
        /// </param>
        /// <param name="body">
        /// The description of the project.
        /// </param>
        public ProjectsCreateForRepoRequest(
            string name,
            string? body)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsCreateForRepoRequest" /> class.
        /// </summary>
        public ProjectsCreateForRepoRequest()
        {
        }
    }
}