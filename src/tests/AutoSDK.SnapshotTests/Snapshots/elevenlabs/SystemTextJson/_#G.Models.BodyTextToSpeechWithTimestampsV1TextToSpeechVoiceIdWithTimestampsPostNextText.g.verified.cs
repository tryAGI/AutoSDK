//HintName: G.Models.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostNextText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The text that comes after the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.
    /// </summary>
    public sealed partial class BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostNextText
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}