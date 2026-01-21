//HintName: G.Models.BodySpeechToTextV1SpeechToTextPostTemperature.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls the randomness of the transcription output. Accepts values between 0.0 and 2.0, where higher values result in more diverse and less deterministic results. If omitted, we will use a temperature based on the model you selected which is usually 0.
    /// </summary>
    public sealed partial class BodySpeechToTextV1SpeechToTextPostTemperature
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}