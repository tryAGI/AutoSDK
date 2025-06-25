//HintName: G.Models.ParagraphsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParagraphsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AudioDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paragraphs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.TranscriptParagraph> Paragraphs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphsResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="confidence"></param>
        /// <param name="audioDuration"></param>
        /// <param name="paragraphs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParagraphsResponse(
            global::System.Guid id,
            double confidence,
            double audioDuration,
            global::System.Collections.Generic.IList<global::G.TranscriptParagraph> paragraphs)
        {
            this.Id = id;
            this.Confidence = confidence;
            this.AudioDuration = audioDuration;
            this.Paragraphs = paragraphs ?? throw new global::System.ArgumentNullException(nameof(paragraphs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParagraphsResponse" /> class.
        /// </summary>
        public ParagraphsResponse()
        {
        }
    }
}