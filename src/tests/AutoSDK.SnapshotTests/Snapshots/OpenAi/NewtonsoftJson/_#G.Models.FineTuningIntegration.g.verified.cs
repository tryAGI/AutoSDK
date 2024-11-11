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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FineTuningIntegrationType Type { get; set; }

        /// <summary>
        /// The settings for your integration with Weights and Biases. This payload specifies the project that<br/>
        /// metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags<br/>
        /// to your run, and set a default entity (team, username, etc) to be associated with your run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wandb", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FineTuningIntegrationWandb Wandb { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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