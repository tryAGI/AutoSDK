//HintName: G.Models.DubbingTranscriptWord.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingTranscriptWord
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Default Value: unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_type")]
        public string? WordType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public global::System.Collections.Generic.IList<global::G.DubbingTranscriptCharacter>? Characters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptWord" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="wordType">
        /// Default Value: unknown
        /// </param>
        /// <param name="startS">
        /// Default Value: 0F
        /// </param>
        /// <param name="endS">
        /// Default Value: 0F
        /// </param>
        /// <param name="characters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingTranscriptWord(
            string? text,
            string? wordType,
            double? startS,
            double? endS,
            global::System.Collections.Generic.IList<global::G.DubbingTranscriptCharacter>? characters)
        {
            this.Text = text;
            this.WordType = wordType;
            this.StartS = startS;
            this.EndS = endS;
            this.Characters = characters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingTranscriptWord" /> class.
        /// </summary>
        public DubbingTranscriptWord()
        {
        }
    }
}