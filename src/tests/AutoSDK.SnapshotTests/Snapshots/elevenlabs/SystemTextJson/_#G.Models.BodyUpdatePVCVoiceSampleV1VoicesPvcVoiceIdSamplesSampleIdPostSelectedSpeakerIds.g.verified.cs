//HintName: G.Models.BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPostSelectedSpeakerIds.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Speaker IDs to be used for PVC training. Make sure you send all the speaker IDs you want to use for PVC training in one request because the last request will override the previous ones.
    /// </summary>
    public sealed partial class BodyUpdatePVCVoiceSampleV1VoicesPvcVoiceIdSamplesSampleIdPostSelectedSpeakerIds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}