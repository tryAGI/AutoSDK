//HintName: G.Models.RecognitionAlternative.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// List of possible job output item values, ordered by likelihood.
    /// </summary>
    public sealed partial class RecognitionAlternative
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display")]
        public global::G.RecognitionDisplay? Display { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionAlternative" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="confidence"></param>
        /// <param name="language"></param>
        /// <param name="display"></param>
        /// <param name="speaker"></param>
        /// <param name="tags"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecognitionAlternative(
            string content,
            float confidence,
            string language,
            global::G.RecognitionDisplay? display,
            string? speaker,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Confidence = confidence;
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Display = display;
            this.Speaker = speaker;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecognitionAlternative" /> class.
        /// </summary>
        public RecognitionAlternative()
        {
        }
    }
}