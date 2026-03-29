//HintName: G.Models.GroupApiProjectResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupApiProjectResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next")]
        public string? Next { get; set; }

        /// <summary>
        /// List of Projects
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ApiProjectResponse> Projects { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupApiProjectResponse" /> class.
        /// </summary>
        /// <param name="projects">
        /// List of Projects
        /// </param>
        /// <param name="next"></param>
        public GroupApiProjectResponse(
            global::System.Collections.Generic.IList<global::G.ApiProjectResponse> projects,
            string? next)
        {
            this.Next = next;
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupApiProjectResponse" /> class.
        /// </summary>
        public GroupApiProjectResponse()
        {
        }
    }
}