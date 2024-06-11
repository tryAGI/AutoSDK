//HintName: G.Models.FineTuningIntegration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FineTuningIntegration
    {
        /// <summary>
        /// The type of the integration being enabled for the fine-tuning job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.FineTuningIntegrationTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuningIntegrationType Type { get; set; }

        /// <summary>
        /// The settings for your integration with Weights and Biases. This payload specifies the project that
        /// metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags
        /// to your run, and set a default entity (team, username, etc) to be associated with your run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuningIntegrationWandb Wandb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}