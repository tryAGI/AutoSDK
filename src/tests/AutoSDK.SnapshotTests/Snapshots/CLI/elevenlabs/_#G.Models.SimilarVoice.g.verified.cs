﻿//HintName: G.Models.SimilarVoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimilarVoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SimilarVoiceCategoryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SimilarVoiceCategory Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarVoice" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="previewUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SimilarVoice(
            string voiceId,
            string name,
            global::G.SimilarVoiceCategory category,
            string? description,
            string? previewUrl)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Category = category;
            this.Description = description;
            this.PreviewUrl = previewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimilarVoice" /> class.
        /// </summary>
        public SimilarVoice()
        {
        }
    }
}