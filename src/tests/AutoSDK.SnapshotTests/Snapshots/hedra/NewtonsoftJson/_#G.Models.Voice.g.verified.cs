//HintName: G.Models.Voice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Voice
    {
        /// <summary>
        /// Default Value: voice
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// External ID of the Voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Labels that help identify the characteristics of the Voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.IList<global::G.VoiceLabel>? Labels { get; set; }

        /// <summary>
        /// Preview URL of the Voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Source of the Voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: voice
        /// </param>
        /// <param name="externalId">
        /// External ID of the Voice.
        /// </param>
        /// <param name="labels">
        /// Labels that help identify the characteristics of the Voice.
        /// </param>
        /// <param name="previewUrl">
        /// Preview URL of the Voice.
        /// </param>
        /// <param name="source">
        /// Source of the Voice.
        /// </param>
        public Voice(
            string? type,
            string? externalId,
            global::System.Collections.Generic.IList<global::G.VoiceLabel>? labels,
            string? previewUrl,
            string? source)
        {
            this.Type = type;
            this.ExternalId = externalId;
            this.Labels = labels;
            this.PreviewUrl = previewUrl;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Voice" /> class.
        /// </summary>
        public Voice()
        {
        }
    }
}