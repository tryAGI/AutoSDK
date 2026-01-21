//HintName: G.Models.BodyTextToSpeechV1TextToSpeechVoiceIdPostPreviousRequestIds.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of request_id of the samples that were generated before this generation. Can be used to improve the speech's continuity when splitting up a large task into multiple requests. The results will be best when the same model is used across the generations. In case both previous_text and previous_request_ids is send, previous_text will be ignored. A maximum of 3 request_ids can be send.
    /// </summary>
    public sealed partial class BodyTextToSpeechV1TextToSpeechVoiceIdPostPreviousRequestIds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}