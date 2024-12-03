//HintName: G.Models.TaggingsByResourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaggingsByResourceType
    {
        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompts")]
        public global::System.Collections.Generic.IList<global::G.Resource>? Prompts { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects")]
        public global::System.Collections.Generic.IList<global::G.Resource>? Projects { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("queues")]
        public global::System.Collections.Generic.IList<global::G.Resource>? Queues { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployments")]
        public global::System.Collections.Generic.IList<global::G.Resource>? Deployments { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiments")]
        public global::System.Collections.Generic.IList<global::G.Resource>? Experiments { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datasets")]
        public global::System.Collections.Generic.IList<global::G.Resource>? Datasets { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dashboards")]
        public global::System.Collections.Generic.IList<global::G.Resource>? Dashboards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggingsByResourceType" /> class.
        /// </summary>
        /// <param name="prompts">
        /// Default Value: []
        /// </param>
        /// <param name="projects">
        /// Default Value: []
        /// </param>
        /// <param name="queues">
        /// Default Value: []
        /// </param>
        /// <param name="deployments">
        /// Default Value: []
        /// </param>
        /// <param name="experiments">
        /// Default Value: []
        /// </param>
        /// <param name="datasets">
        /// Default Value: []
        /// </param>
        /// <param name="dashboards">
        /// Default Value: []
        /// </param>
        public TaggingsByResourceType(
            global::System.Collections.Generic.IList<global::G.Resource>? prompts,
            global::System.Collections.Generic.IList<global::G.Resource>? projects,
            global::System.Collections.Generic.IList<global::G.Resource>? queues,
            global::System.Collections.Generic.IList<global::G.Resource>? deployments,
            global::System.Collections.Generic.IList<global::G.Resource>? experiments,
            global::System.Collections.Generic.IList<global::G.Resource>? datasets,
            global::System.Collections.Generic.IList<global::G.Resource>? dashboards)
        {
            this.Prompts = prompts;
            this.Projects = projects;
            this.Queues = queues;
            this.Deployments = deployments;
            this.Experiments = experiments;
            this.Datasets = datasets;
            this.Dashboards = dashboards;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaggingsByResourceType" /> class.
        /// </summary>
        public TaggingsByResourceType()
        {
        }
    }
}