//HintName: G.Models.OrganizationProjectsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationProjectsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OrganizationProject> Projects { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectsResponse" /> class.
        /// </summary>
        /// <param name="projects"></param>
        public OrganizationProjectsResponse(
            global::System.Collections.Generic.IList<global::G.OrganizationProject> projects)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationProjectsResponse" /> class.
        /// </summary>
        public OrganizationProjectsResponse()
        {
        }
    }
}