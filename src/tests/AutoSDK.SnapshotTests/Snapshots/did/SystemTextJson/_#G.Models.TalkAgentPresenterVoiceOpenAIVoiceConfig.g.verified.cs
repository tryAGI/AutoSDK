//HintName: G.Models.TalkAgentPresenterVoiceOpenAIVoiceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Voice customization options
    /// </summary>
    public sealed partial class TalkAgentPresenterVoiceOpenAIVoiceConfig
    {
        /// <summary>
        /// The style of the voice.<br/>
        /// Available styles change between voices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        public string? Style { get; set; }

        /// <summary>
        /// The speed of the voice.<br/>
        /// The value is relative to 1, 0.5 being half speed, 2 being twice as fast, etc.<br/>
        /// Another option is a constant value from x-slow/slow/medium/fast/x-fast.<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public string? Rate { get; set; }

        /// <summary>
        /// The pitch of the voice.<br/>
        /// Value could be an absolute value in Hz (including units), a relative value in Hz or st(semitones)<br/>
        /// or a constant value from x-low/low/medium/high/x-high.<br/>
        /// Example: +2st
        /// </summary>
        /// <example>+2st</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pitch")]
        public string? Pitch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TalkAgentPresenterVoiceOpenAIVoiceConfig" /> class.
        /// </summary>
        /// <param name="style">
        /// The style of the voice.<br/>
        /// Available styles change between voices.
        /// </param>
        /// <param name="rate">
        /// The speed of the voice.<br/>
        /// The value is relative to 1, 0.5 being half speed, 2 being twice as fast, etc.<br/>
        /// Another option is a constant value from x-slow/slow/medium/fast/x-fast.<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="pitch">
        /// The pitch of the voice.<br/>
        /// Value could be an absolute value in Hz (including units), a relative value in Hz or st(semitones)<br/>
        /// or a constant value from x-low/low/medium/high/x-high.<br/>
        /// Example: +2st
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TalkAgentPresenterVoiceOpenAIVoiceConfig(
            string? style,
            string? rate,
            string? pitch)
        {
            this.Style = style;
            this.Rate = rate;
            this.Pitch = pitch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TalkAgentPresenterVoiceOpenAIVoiceConfig" /> class.
        /// </summary>
        public TalkAgentPresenterVoiceOpenAIVoiceConfig()
        {
        }
    }
}