//HintName: G.Models.PlayDTMFToolConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allows the agent to play DTMF tones during a phone call.<br/>
    /// This tool can be used to interact with automated phone systems, such as<br/>
    /// navigating phone menus, entering extensions, or inputting numeric codes.
    /// </summary>
    public sealed partial class PlayDTMFToolConfig
    {
        /// <summary>
        /// Default Value: play_keypad_touch_tone
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        public string? SystemToolType { get; set; }

        /// <summary>
        /// If true, send DTMF tones out-of-band using RFC 4733 (useful for SIP calls only). If false, send DTMF as in-band audio tones (default, works for all call types).<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_out_of_band_dtmf")]
        public bool? UseOutOfBandDtmf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayDTMFToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: play_keypad_touch_tone
        /// </param>
        /// <param name="useOutOfBandDtmf">
        /// If true, send DTMF tones out-of-band using RFC 4733 (useful for SIP calls only). If false, send DTMF as in-band audio tones (default, works for all call types).<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlayDTMFToolConfig(
            string? systemToolType,
            bool? useOutOfBandDtmf)
        {
            this.SystemToolType = systemToolType;
            this.UseOutOfBandDtmf = useOutOfBandDtmf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayDTMFToolConfig" /> class.
        /// </summary>
        public PlayDTMFToolConfig()
        {
        }
    }
}