//HintName: G.Models.ProjectVoiceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectVoiceResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alias", Required = global::Newtonsoft.Json.Required.Always)]
        public string Alias { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stability", Required = global::Newtonsoft.Json.Required.Always)]
        public double Stability { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("similarity_boost", Required = global::Newtonsoft.Json.Required.Always)]
        public double SimilarityBoost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style", Required = global::Newtonsoft.Json.Required.Always)]
        public double Style { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_pinned", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPinned { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("use_speaker_boost", Required = global::Newtonsoft.Json.Required.Always)]
        public bool UseSpeakerBoost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("volume_gain", Required = global::Newtonsoft.Json.Required.Always)]
        public double VolumeGain { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speed", Required = global::Newtonsoft.Json.Required.Always)]
        public double Speed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVoiceResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="alias"></param>
        /// <param name="stability"></param>
        /// <param name="similarityBoost"></param>
        /// <param name="style"></param>
        /// <param name="isPinned"></param>
        /// <param name="useSpeakerBoost"></param>
        /// <param name="volumeGain"></param>
        /// <param name="speed"></param>
        public ProjectVoiceResponseModel(
            string voiceId,
            string alias,
            double stability,
            double similarityBoost,
            double style,
            bool isPinned,
            bool useSpeakerBoost,
            double volumeGain,
            double speed)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
            this.Style = style;
            this.IsPinned = isPinned;
            this.UseSpeakerBoost = useSpeakerBoost;
            this.VolumeGain = volumeGain;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVoiceResponseModel" /> class.
        /// </summary>
        public ProjectVoiceResponseModel()
        {
        }
    }
}