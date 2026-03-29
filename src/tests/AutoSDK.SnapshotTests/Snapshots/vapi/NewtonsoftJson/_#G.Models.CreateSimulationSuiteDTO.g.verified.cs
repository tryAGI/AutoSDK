//HintName: G.Models.CreateSimulationSuiteDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSimulationSuiteDTO
    {
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
        /// This is the list of simulation IDs to include in the suite.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("simulationIds", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> SimulationIds { get; set; } = default!;

        /// <summary>
        /// Optional folder path for organizing simulation suites.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSimulationSuiteDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the simulation suite.<br/>
        /// Example: Checkout Flow Tests
        /// </param>
        /// <param name="simulationIds">
        /// This is the list of simulation IDs to include in the suite.
        /// </param>
        /// <param name="slackWebhookUrl">
        /// This is the Slack webhook URL for notifications.
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing simulation suites.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </param>
        public CreateSimulationSuiteDTO(
            string name,
            global::System.Collections.Generic.IList<string> simulationIds,
            string? slackWebhookUrl,
            string? path)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SlackWebhookUrl = slackWebhookUrl;
            this.SimulationIds = simulationIds ?? throw new global::System.ArgumentNullException(nameof(simulationIds));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSimulationSuiteDTO" /> class.
        /// </summary>
        public CreateSimulationSuiteDTO()
        {
        }
    }
}