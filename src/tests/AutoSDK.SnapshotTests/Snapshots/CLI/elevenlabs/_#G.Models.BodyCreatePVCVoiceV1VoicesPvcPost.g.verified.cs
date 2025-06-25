//HintName: G.Models.BodyCreatePVCVoiceV1VoicesPvcPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreatePVCVoiceV1VoicesPvcPost
    {
        /// <summary>
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.<br/>
        /// Example: John Smith
        /// </summary>
        /// <example>John Smith</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Language used in the samples.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Description to use for the created voice.<br/>
        /// Example: An old American male voice with a slight hoarseness in his throat. Perfect for news.
        /// </summary>
        /// <example>An old American male voice with a slight hoarseness in his throat. Perfect for news.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Serialized labels dictionary for the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePVCVoiceV1VoicesPvcPost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.<br/>
        /// Example: John Smith
        /// </param>
        /// <param name="language">
        /// Language used in the samples.<br/>
        /// Example: en
        /// </param>
        /// <param name="description">
        /// Description to use for the created voice.<br/>
        /// Example: An old American male voice with a slight hoarseness in his throat. Perfect for news.
        /// </param>
        /// <param name="labels">
        /// Serialized labels dictionary for the voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreatePVCVoiceV1VoicesPvcPost(
            string name,
            string language,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Description = description;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreatePVCVoiceV1VoicesPvcPost" /> class.
        /// </summary>
        public BodyCreatePVCVoiceV1VoicesPvcPost()
        {
        }
    }
}