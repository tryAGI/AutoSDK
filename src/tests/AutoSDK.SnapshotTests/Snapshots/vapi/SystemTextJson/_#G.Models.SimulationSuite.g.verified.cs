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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the organization this suite belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the suite was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the suite was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

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
        /// Optional folder path for organizing simulation suites.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// This is the list of simulation IDs in this suite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulationIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SimulationIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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