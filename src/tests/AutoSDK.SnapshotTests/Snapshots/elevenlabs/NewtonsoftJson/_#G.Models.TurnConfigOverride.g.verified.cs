//HintName: G.Models.TurnConfigOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"soft_timeout_config":{"message":"Hhmmmm...yeah."}}
    /// </summary>
    public sealed partial class TurnConfigOverride
    {
        /// <summary>
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("soft_timeout_config")]
        public global::G.SoftTimeoutConfigOverride? SoftTimeoutConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigOverride" /> class.
        /// </summary>
        /// <param name="softTimeoutConfig">
        /// Configuration for soft timeout functionality. Provides immediate feedback during longer LLM responses.
        /// </param>
        public TurnConfigOverride(
            global::G.SoftTimeoutConfigOverride? softTimeoutConfig)
        {
            this.SoftTimeoutConfig = softTimeoutConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigOverride" /> class.
        /// </summary>
        public TurnConfigOverride()
        {
        }
    }
}