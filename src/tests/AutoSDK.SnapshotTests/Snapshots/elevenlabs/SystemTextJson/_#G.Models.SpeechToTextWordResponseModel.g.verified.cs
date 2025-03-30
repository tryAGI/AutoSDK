//HintName: G.Models.SpeechToTextWordResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Word-level detail of the transcription with timing information.
    /// </summary>
    public sealed partial class SpeechToTextWordResponseModel
    {
        /// <summary>
        /// The word or sound that was transcribed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The start time of the word or sound in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        /// The end time of the word or sound in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// The type of the word or sound. 'audio_event' is used for non-word sounds like laughter or footsteps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SpeechToTextWordResponseModelType Type { get; set; }

        /// <summary>
        /// Unique identifier for the speaker of this word.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_id")]
        public string? SpeakerId { get; set; }

        /// <summary>
        /// The characters that make up the word and their timing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public global::System.Collections.Generic.IList<global::G.SpeechToTextCharacterResponseModel>? Characters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextWordResponseModel" /> class.
        /// </summary>
        /// <param name="text">
        /// The word or sound that was transcribed.
        /// </param>
        /// <param name="start">
        /// The start time of the word or sound in seconds.
        /// </param>
        /// <param name="end">
        /// The end time of the word or sound in seconds.
        /// </param>
        /// <param name="type">
        /// The type of the word or sound. 'audio_event' is used for non-word sounds like laughter or footsteps.
        /// </param>
        /// <param name="speakerId">
        /// Unique identifier for the speaker of this word.
        /// </param>
        /// <param name="characters">
        /// The characters that make up the word and their timing information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechToTextWordResponseModel(
            string text,
            global::G.SpeechToTextWordResponseModelType type,
            double? start,
            double? end,
            string? speakerId,
            global::System.Collections.Generic.IList<global::G.SpeechToTextCharacterResponseModel>? characters)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
            this.Start = start;
            this.End = end;
            this.SpeakerId = speakerId;
            this.Characters = characters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechToTextWordResponseModel" /> class.
        /// </summary>
        public SpeechToTextWordResponseModel()
        {
        }
    }
}