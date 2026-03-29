//HintName: G.Models.SimulationSuite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationSuite
    {
        /// <summary>
        /// This is the unique identifier for the simulation suite.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the organization this suite belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the suite was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the suite was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the name of the simulation suite.<br/>
        /// Example: Checkout Flow Tests
        /// </summary>
        /// <example>Checkout Flow Tests</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// This is the Slack webhook URL for notifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slackWebhookUrl")]
        public string? SlackWebhookUrl { get; set; }

        /// <summary>
        /// Optional folder path for organizing simulation suites.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// This is the list of simulation IDs in this suite.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("simulationIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> SimulationIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationSuite" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the simulation suite.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the organization this suite belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the suite was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the suite was last updated.
        /// </param>
        /// <param name="name">
        /// This is the name of the simulation suite.<br/>
        /// Example: Checkout Flow Tests
        /// </param>
        /// <param name="simulationIds">
        /// This is the list of simulation IDs in this suite.
        /// </param>
        /// <param name="slackWebhookUrl">
        /// This is the Slack webhook URL for notifications.
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing simulation suites.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </param>
        public SimulationSuite(
            global::System.Guid id,
            global::System.Guid orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string name,
            global::System.Collections.Generic.IList<string> simulationIds,
            string? slackWebhookUrl,
            string? path)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SlackWebhookUrl = slackWebhookUrl;
            this.Path = path;
            this.SimulationIds = simulationIds ?? throw new global::System.ArgumentNullException(nameof(simulationIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationSuite" /> class.
        /// </summary>
        public SimulationSuite()
        {
        }
    }
}