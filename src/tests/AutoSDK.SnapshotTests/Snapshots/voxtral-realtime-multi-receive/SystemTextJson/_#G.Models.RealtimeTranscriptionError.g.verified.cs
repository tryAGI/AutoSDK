//HintName: G.Models.RealtimeTranscriptionError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// error server event.
    /// </summary>
    public sealed partial class RealtimeTranscriptionError
    {
        /// <summary>
        /// Must be 'error'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeTranscriptionErrorTypeJsonConverter))]
        public global::G.RealtimeTranscriptionErrorType Type { get; set; }

        /// <summary>
        /// Error detail block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RealtimeTranscriptionErrorDetail Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionError" /> class.
        /// </summary>
        /// <param name="error">
        /// Error detail block.
        /// </param>
        /// <param name="type">
        /// Must be 'error'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionError(
            global::G.RealtimeTranscriptionErrorDetail error,
            global::G.RealtimeTranscriptionErrorType type)
        {
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionError" /> class.
        /// </summary>
        public RealtimeTranscriptionError()
        {
        }

    }
}