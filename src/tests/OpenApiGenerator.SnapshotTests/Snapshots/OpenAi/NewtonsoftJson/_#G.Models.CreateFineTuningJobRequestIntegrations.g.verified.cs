//HintName: G.Models.CreateFineTuningJobRequestIntegrations.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFineTuningJobRequestIntegrations
    {
        /// <summary>
        /// The type of integration to enable. Currently, only "wandb" (Weights and Biases) is supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.OneOf<CreateFineTuningJobRequestIntegrationsType> Type { get; set; } = default!;

        /// <summary>
        /// The settings for your integration with Weights and Biases. This payload specifies the project that
        /// metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags
        /// to your run, and set a default entity (team, username, etc) to be associated with your run.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wandb", Required = global::Newtonsoft.Json.Required.Always)]
        public CreateFineTuningJobRequestIntegrationsWandb Wandb { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}