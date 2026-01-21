//HintName: G.Models.VoiceSettingsResponseModelStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Determines the style exaggeration of the voice. This setting attempts to amplify the style of the original speaker. It does consume additional computational resources and might increase latency if set to anything other than 0.
    /// </summary>
    public sealed partial class VoiceSettingsResponseModelStyle
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}