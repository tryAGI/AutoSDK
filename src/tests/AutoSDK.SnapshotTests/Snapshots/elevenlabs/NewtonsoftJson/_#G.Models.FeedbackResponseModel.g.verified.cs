//HintName: G.Models.FeedbackResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbs_up", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ThumbsUp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public string Feedback { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotions", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Emotions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inaccurate_clone", Required = global::Newtonsoft.Json.Required.Always)]
        public bool InaccurateClone { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("glitches", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Glitches { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_quality", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AudioQuality { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("other", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Other { get; set; } = default!;

        /// <summary>
        /// Default Value: not_reviewed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_status")]
        public string? ReviewStatus { get; set; } = "not_reviewed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}