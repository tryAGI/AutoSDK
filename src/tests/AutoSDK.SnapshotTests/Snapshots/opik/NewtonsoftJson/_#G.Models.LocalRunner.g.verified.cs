//HintName: G.Models.LocalRunner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LocalRunner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LocalRunnerStatusJsonConverter))]
        public global::G.LocalRunnerStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connected_at")]
        public global::System.DateTime? ConnectedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agents")]
        public global::System.Collections.Generic.IList<global::G.Agent>? Agents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunner" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="status"></param>
        /// <param name="connectedAt"></param>
        /// <param name="agents"></param>
        public LocalRunner(
            global::System.Guid? id,
            string? name,
            global::System.Guid? projectId,
            global::G.LocalRunnerStatus? status,
            global::System.DateTime? connectedAt,
            global::System.Collections.Generic.IList<global::G.Agent>? agents)
        {
            this.Id = id;
            this.Name = name;
            this.ProjectId = projectId;
            this.Status = status;
            this.ConnectedAt = connectedAt;
            this.Agents = agents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalRunner" /> class.
        /// </summary>
        public LocalRunner()
        {
        }
    }
}