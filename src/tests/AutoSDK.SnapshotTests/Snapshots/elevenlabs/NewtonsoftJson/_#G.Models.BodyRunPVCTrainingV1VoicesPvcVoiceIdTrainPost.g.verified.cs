//HintName: G.Models.BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost
    {
        /// <summary>
        /// The model ID to use for the conversion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The model ID to use for the conversion.
        /// </param>
        public BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost(
            string? modelId)
        {
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost" /> class.
        /// </summary>
        public BodyRunPvcTrainingV1VoicesPvcVoiceIdTrainPost()
        {
        }
    }
}