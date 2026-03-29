//HintName: G.Models.Utterance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Utterance
    {
        /// <summary>
        /// Documents whether this utterance is spoken by agent or user.<br/>
        /// Example: agent
        /// </summary>
        /// <example>agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UtteranceRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UtteranceRole Role { get; set; }

        /// <summary>
        /// Transcript of the utterances.<br/>
        /// Example: hi how are you doing?
        /// </summary>
        /// <example>hi how are you doing?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Array of words in the utterance with the word timestamp. Useful for understanding what word was spoken at what time. Note that the word timestamp is not guaranteed to be accurate, it's more like an approximation.<br/>
        /// Example: [{"word":"hi","start":0.7,"end":1.3}]
        /// </summary>
        /// <example>[{"word":"hi","start":0.7,"end":1.3}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UtteranceWord> Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Utterance" /> class.
        /// </summary>
        /// <param name="role">
        /// Documents whether this utterance is spoken by agent or user.<br/>
        /// Example: agent
        /// </param>
        /// <param name="content">
        /// Transcript of the utterances.<br/>
        /// Example: hi how are you doing?
        /// </param>
        /// <param name="words">
        /// Array of words in the utterance with the word timestamp. Useful for understanding what word was spoken at what time. Note that the word timestamp is not guaranteed to be accurate, it's more like an approximation.<br/>
        /// Example: [{"word":"hi","start":0.7,"end":1.3}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Utterance(
            global::G.UtteranceRole role,
            string content,
            global::System.Collections.Generic.IList<global::G.UtteranceWord> words)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Utterance" /> class.
        /// </summary>
        public Utterance()
        {
        }
    }
}