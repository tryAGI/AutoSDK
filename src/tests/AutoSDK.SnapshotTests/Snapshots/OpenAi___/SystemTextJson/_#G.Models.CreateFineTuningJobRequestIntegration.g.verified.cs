//HintName: G.Models.CreateFineTuningJobRequestIntegration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFineTuningJobRequestIntegration
    {
        /// <summary>
        /// The type of integration to enable. Currently, only "wandb" (Weights and Biases) is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateFineTuningJobRequestIntegrationTypeJsonConverter))]
        public global::G.CreateFineTuningJobRequestIntegrationType Type { get; set; }

        /// <summary>
        /// The settings for your integration with Weights and Biases. This payload specifies the project that<br/>
        /// metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags<br/>
        /// to your run, and set a default entity (team, username, etc) to be associated with your run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wandb")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateFineTuningJobRequestIntegrationWandb Wandb { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningJobRequestIntegration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of integration to enable. Currently, only "wandb" (Weights and Biases) is supported.
        /// </param>
        /// <param name="wandb">
        /// The settings for your integration with Weights and Biases. This payload specifies the project that<br/>
        /// metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags<br/>
        /// to your run, and set a default entity (team, username, etc) to be associated with your run.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateFineTuningJobRequestIntegration(
            global::G.CreateFineTuningJobRequestIntegrationWandb wandb,
            global::G.CreateFineTuningJobRequestIntegrationType type)
        {
            this.Wandb = wandb ?? throw new global::System.ArgumentNullException(nameof(wandb));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningJobRequestIntegration" /> class.
        /// </summary>
        public CreateFineTuningJobRequestIntegration()
        {
        }
    }
}