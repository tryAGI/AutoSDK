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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// This is the Slack webhook URL for notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slackWebhookUrl")]
        public string? SlackWebhookUrl { get; set; }

        /// <summary>
        /// This is the list of simulation IDs to include in the suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulationIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SimulationIds { get; set; }

        /// <summary>
        /// Optional folder path for organizing simulation suites.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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