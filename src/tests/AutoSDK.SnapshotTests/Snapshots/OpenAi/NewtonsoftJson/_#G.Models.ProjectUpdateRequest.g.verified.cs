//HintName: G.Models.ProjectUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectUpdateRequest
    {
        /// <summary>
        /// The updated name of the project, this name appears in reports.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The updated name of the project, this name appears in reports.
        /// </param>
        public ProjectUpdateRequest(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpdateRequest" /> class.
        /// </summary>
        public ProjectUpdateRequest()
        {
        }
    }
}