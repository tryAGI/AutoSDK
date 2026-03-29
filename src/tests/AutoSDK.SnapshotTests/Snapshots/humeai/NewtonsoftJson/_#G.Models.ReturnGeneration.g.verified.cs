//HintName: G.Models.ReturnGeneration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReturnGeneration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio")]
        public string? Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnGeneration" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="duration"></param>
        /// <param name="audio"></param>
        public ReturnGeneration(
            string? generationId,
            double? duration,
            string? audio)
        {
            this.GenerationId = generationId;
            this.Duration = duration;
            this.Audio = audio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnGeneration" /> class.
        /// </summary>
        public ReturnGeneration()
        {
        }
    }
}