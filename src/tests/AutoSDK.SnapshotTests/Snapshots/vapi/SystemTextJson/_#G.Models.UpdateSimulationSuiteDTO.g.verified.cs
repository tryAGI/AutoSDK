//HintName: G.Models.UpdateSimulationSuiteDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateSimulationSuiteDTO
    {
        /// <summary>
        /// This is the name of the simulation suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the Slack webhook URL for notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slackWebhookUrl")]
        public string? SlackWebhookUrl { get; set; }

        /// <summary>
        /// This is the list of simulation IDs to include in the suite (replaces existing).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulationIds")]
        public global::System.Collections.Generic.IList<string>? SimulationIds { get; set; }

        /// <summary>
        /// Optional folder path for organizing simulation suites.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSimulationSuiteDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the simulation suite.
        /// </param>
        /// <param name="slackWebhookUrl">
        /// This is the Slack webhook URL for notifications.
        /// </param>
        /// <param name="simulationIds">
        /// This is the list of simulation IDs to include in the suite (replaces existing).
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing simulation suites.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSimulationSuiteDTO(
            string? name,
            string? slackWebhookUrl,
            global::System.Collections.Generic.IList<string>? simulationIds,
            string? path)
        {
            this.Name = name;
            this.SlackWebhookUrl = slackWebhookUrl;
            this.SimulationIds = simulationIds;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSimulationSuiteDTO" /> class.
        /// </summary>
        public UpdateSimulationSuiteDTO()
        {
        }
    }
}