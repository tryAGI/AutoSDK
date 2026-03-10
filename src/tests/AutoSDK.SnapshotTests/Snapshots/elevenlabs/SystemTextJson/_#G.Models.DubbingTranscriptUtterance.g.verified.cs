//HintName: G.Models.DubbingTranscriptUtterance.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingTranscriptUtterance
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        public string? SpeakerId { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_s")]
        public double? StartS { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_s")]
        public double? EndS { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::G.DubbingTranscriptWord>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptUtterance" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="speakerId">
        /// Default Value: unknown
        /// </param>
        /// <param name="startS">
        /// Default Value: 0F
        /// </param>
        /// <param name="endS">
        /// Default Value: 0F
        /// </param>
        /// <param name="words"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingTranscriptUtterance(
            string? text,
            string? speakerId,
            double? startS,
            double? endS,
            global::System.Collections.Generic.IList<global::G.DubbingTranscriptWord>? words)
        {
            this.Text = text;
            this.SpeakerId = speakerId;
            this.StartS = startS;
            this.EndS = endS;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptUtterance" /> class.
        /// </summary>
        public DubbingTranscriptUtterance()
        {
        }
    }
}