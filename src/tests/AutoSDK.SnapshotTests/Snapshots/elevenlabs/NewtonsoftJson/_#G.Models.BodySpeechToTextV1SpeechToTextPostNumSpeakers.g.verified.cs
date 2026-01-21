//HintName: G.Models.BodySpeechToTextV1SpeechToTextPostNumSpeakers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The maximum amount of speakers talking in the uploaded file. Can help with predicting who speaks when. The maximum amount of speakers that can be predicted is 32. Defaults to null, in this case the amount of speakers is set to the maximum value the model supports.
    /// </summary>
    public sealed partial class BodySpeechToTextV1SpeechToTextPostNumSpeakers
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}