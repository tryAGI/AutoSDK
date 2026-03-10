//HintName: G.Models.VoiceDesignRequestModelReferenceAudioBase64.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reference audio to use for the voice generation. The audio should be base64 encoded. Only supported when using the  eleven_ttv_v3 model.
    /// </summary>
    public sealed partial class VoiceDesignRequestModelReferenceAudioBase64
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}