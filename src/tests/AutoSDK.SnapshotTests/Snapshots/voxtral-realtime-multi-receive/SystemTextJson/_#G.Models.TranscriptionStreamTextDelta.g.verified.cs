//HintName: G.Models.TranscriptionStreamTextDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A delta of transcribed text.
    /// </summary>
    public sealed partial class TranscriptionStreamTextDelta
    {
        /// <summary>
        /// Must be 'transcription.text.delta'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriptionStreamTextDeltaTypeJsonConverter))]
        public global::G.TranscriptionStreamTextDeltaType Type { get; set; }

        /// <summary>
        /// Text added to the running transcript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamTextDelta" /> class.
        /// </summary>
        /// <param name="delta">
        /// Text added to the running transcript.
        /// </param>
        /// <param name="type">
        /// Must be 'transcription.text.delta'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptionStreamTextDelta(
            string delta,
            global::G.TranscriptionStreamTextDeltaType type)
        {
            this.Type = type;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptionStreamTextDelta" /> class.
        /// </summary>
        public TranscriptionStreamTextDelta()
        {
        }

    }
}