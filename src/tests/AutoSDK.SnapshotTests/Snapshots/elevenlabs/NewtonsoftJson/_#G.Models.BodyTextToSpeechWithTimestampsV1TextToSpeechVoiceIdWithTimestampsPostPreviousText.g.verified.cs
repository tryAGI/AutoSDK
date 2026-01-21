//HintName: G.Models.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostPreviousText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The text that came before the text of the current request. Can be used to improve the speech's continuity when concatenating together multiple generations or to influence the speech's continuity in the current generation.
    /// </summary>
    public sealed partial class BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostPreviousText
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}