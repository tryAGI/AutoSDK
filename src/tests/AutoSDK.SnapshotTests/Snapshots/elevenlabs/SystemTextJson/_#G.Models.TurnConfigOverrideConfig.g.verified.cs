//HintName: G.Models.TurnConfigOverrideConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TurnConfigOverrideConfig
    {
        /// <summary>
        /// Configures overrides for nested fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("soft_timeout_config")]
        public global::G.SoftTimeoutConfigOverrideConfig? SoftTimeoutConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigOverrideConfig" /> class.
        /// </summary>
        /// <param name="softTimeoutConfig">
        /// Configures overrides for nested fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TurnConfigOverrideConfig(
            global::G.SoftTimeoutConfigOverrideConfig? softTimeoutConfig)
        {
            this.SoftTimeoutConfig = softTimeoutConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfigOverrideConfig" /> class.
        /// </summary>
        public TurnConfigOverrideConfig()
        {
        }
    }
}