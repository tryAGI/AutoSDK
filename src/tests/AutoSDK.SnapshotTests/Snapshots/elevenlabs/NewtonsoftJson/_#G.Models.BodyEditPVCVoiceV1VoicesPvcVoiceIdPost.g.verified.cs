//HintName: G.Models.BodyEditPVCVoiceV1VoicesPvcVoiceIdPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyEditPVCVoiceV1VoicesPvcVoiceIdPost
    {
        /// <summary>
        /// The name that identifies this voice. This will be displayed in the dropdown of the website.<br/>
        /// Example: John Smith
        /// </summary>
        /// <example>John Smith</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Language used in the samples.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Description to use for the created voice.<br/>
        /// Example: An old American male voice with a slight hoarseness in his throat. Perfect for news.
        /// </summary>
        /// <example>An old American male voice with a slight hoarseness in his throat. Perfect for news.</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Serialized labels dictionary for the voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditPVCVoiceV1VoicesPvcVoiceIdPost" /> class.
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
        public BodyEditPVCVoiceV1VoicesPvcVoiceIdPost(
            string? name,
            string? language,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.Name = name;
            this.Language = language;
            this.Description = description;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditPVCVoiceV1VoicesPvcVoiceIdPost" /> class.
        /// </summary>
        public BodyEditPVCVoiceV1VoicesPvcVoiceIdPost()
        {
        }
    }
}