//HintName: G.Models.BodyTextToSpeechV1TextToSpeechVoiceIdPostSeed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.
    /// </summary>
    public sealed partial class BodyTextToSpeechV1TextToSpeechVoiceIdPostSeed
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}