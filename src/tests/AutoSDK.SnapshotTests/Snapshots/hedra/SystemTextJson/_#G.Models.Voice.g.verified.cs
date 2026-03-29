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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// External ID of the Voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_id")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Labels that help identify the characteristics of the Voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::G.VoiceLabel>? Labels { get; set; }

        /// <summary>
        /// Preview URL of the Voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Source of the Voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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