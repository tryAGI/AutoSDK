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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Language used in the samples.<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

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