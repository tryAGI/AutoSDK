//HintName: G.Models.AgentOverrideConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentOverrideConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interruption_sensitivity")]
        public double? InterruptionSensitivity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responsiveness")]
        public double? Responsiveness { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_speed")]
        public double? VoiceSpeed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOverrideConfig" /> class.
        /// </summary>
        /// <param name="interruptionSensitivity"></param>
        /// <param name="responsiveness"></param>
        /// <param name="voiceSpeed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentOverrideConfig(
            double? interruptionSensitivity,
            double? responsiveness,
            double? voiceSpeed)
        {
            this.InterruptionSensitivity = interruptionSensitivity;
            this.Responsiveness = responsiveness;
            this.VoiceSpeed = voiceSpeed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentOverrideConfig" /> class.
        /// </summary>
        public AgentOverrideConfig()
        {
        }
    }
}