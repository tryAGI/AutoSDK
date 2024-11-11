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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuningIntegrationTypeJsonConverter))]
        public global::G.FineTuningIntegrationType Type { get; set; }

        /// <summary>
        /// The settings for your integration with Weights and Biases. This payload specifies the project that<br/>
        /// metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags<br/>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningIntegration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the integration being enabled for the fine-tuning job
        /// </param>
        /// <param name="wandb">
        /// The settings for your integration with Weights and Biases. This payload specifies the project that<br/>
        /// metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags<br/>
        /// to your run, and set a default entity (team, username, etc) to be associated with your run.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FineTuningIntegration(
            global::G.FineTuningIntegrationWandb wandb,
            global::G.FineTuningIntegrationType type)
        {
            this.Wandb = wandb ?? throw new global::System.ArgumentNullException(nameof(wandb));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningIntegration" /> class.
        /// </summary>
        public FineTuningIntegration()
        {
        }
    }
}