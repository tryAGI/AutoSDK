//HintName: G.Models.BodyGenerateCompositionPlanV1MusicPlanPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyGenerateCompositionPlanV1MusicPlanPost
    {
        /// <summary>
        /// A simple text prompt to compose a plan from.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// The length of the composition plan to generate in milliseconds. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("music_length_ms")]
        public int? MusicLengthMs { get; set; }

        /// <summary>
        /// An optional composition plan to use as a source for the new composition plan.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_composition_plan")]
        public global::G.MusicPrompt? SourceCompositionPlan { get; set; }

        /// <summary>
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_id")]
        public global::G.BodyGenerateCompositionPlanV1MusicPlanPostModelId? ModelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateCompositionPlanV1MusicPlanPost" /> class.
        /// </summary>
        /// <param name="prompt">
        /// A simple text prompt to compose a plan from.
        /// </param>
        /// <param name="musicLengthMs">
        /// The length of the composition plan to generate in milliseconds. Must be between 3000ms and 600000ms. Optional - if not provided, the model will choose a length based on the prompt.
        /// </param>
        /// <param name="sourceCompositionPlan">
        /// An optional composition plan to use as a source for the new composition plan.
        /// </param>
        /// <param name="modelId">
        /// The model to use for the generation.<br/>
        /// Default Value: music_v1
        /// </param>
        public BodyGenerateCompositionPlanV1MusicPlanPost(
            string prompt,
            int? musicLengthMs,
            global::G.MusicPrompt? sourceCompositionPlan,
            global::G.BodyGenerateCompositionPlanV1MusicPlanPostModelId? modelId)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.MusicLengthMs = musicLengthMs;
            this.SourceCompositionPlan = sourceCompositionPlan;
            this.ModelId = modelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyGenerateCompositionPlanV1MusicPlanPost" /> class.
        /// </summary>
        public BodyGenerateCompositionPlanV1MusicPlanPost()
        {
        }
    }
}