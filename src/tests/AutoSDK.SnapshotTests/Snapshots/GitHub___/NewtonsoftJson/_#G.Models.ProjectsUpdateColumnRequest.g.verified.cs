//HintName: G.Models.ProjectsUpdateColumnRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsUpdateColumnRequest
    {
        /// <summary>
        /// Name of the project column<br/>
        /// Example: Remaining tasks
        /// </summary>
        /// <example>Remaining tasks</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateColumnRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the project column<br/>
        /// Example: Remaining tasks
        /// </param>
        public ProjectsUpdateColumnRequest(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectsUpdateColumnRequest" /> class.
        /// </summary>
        public ProjectsUpdateColumnRequest()
        {
        }
    }
}