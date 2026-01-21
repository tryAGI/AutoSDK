//HintName: G.Models.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostSeed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same seed and parameters should return the same result. Determinism is not guaranteed. Must be integer between 0 and 4294967295.
    /// </summary>
    public sealed partial class BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostSeed
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}