﻿//HintName: G.Models.CreateTranscriptionResponseVerboseJson.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a verbose json transcription response returned by model, based on the provided input.
    /// </summary>
    public sealed partial class CreateTranscriptionResponseVerboseJson
    {
        /// <summary>
        /// The language of the input audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language", Required = global::Newtonsoft.Json.Required.Always)]
        public string Language { get; set; } = default!;

        /// <summary>
        /// The duration of the input audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double Duration { get; set; } = default!;

        /// <summary>
        /// The transcribed text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Extracted words and their corresponding timestamps.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("words")]
        public global::System.Collections.Generic.IList<global::G.TranscriptionWord>? Words { get; set; }

        /// <summary>
        /// Segments of the transcribed text and their corresponding details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segments")]
        public global::System.Collections.Generic.IList<global::G.TranscriptionSegment>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseVerboseJson" /> class.
        /// </summary>
        /// <param name="language">
        /// The language of the input audio.
        /// </param>
        /// <param name="duration">
        /// The duration of the input audio.
        /// </param>
        /// <param name="text">
        /// The transcribed text.
        /// </param>
        /// <param name="words">
        /// Extracted words and their corresponding timestamps.
        /// </param>
        /// <param name="segments">
        /// Segments of the transcribed text and their corresponding details.
        /// </param>
        public CreateTranscriptionResponseVerboseJson(
            string language,
            double duration,
            string text,
            global::System.Collections.Generic.IList<global::G.TranscriptionWord>? words,
            global::System.Collections.Generic.IList<global::G.TranscriptionSegment>? segments)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Duration = duration;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words;
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseVerboseJson" /> class.
        /// </summary>
        public CreateTranscriptionResponseVerboseJson()
        {
        }
    }
}