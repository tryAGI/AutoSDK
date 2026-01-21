//HintName: G.Models.SpeechHistoryItemResponseModelDialogue.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The dialogue (voice and text pairs) used to generate the audio item. If this is set then the top level `text` and `voice_id` fields will be empty.
    /// </summary>
    public sealed partial class SpeechHistoryItemResponseModelDialogue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}