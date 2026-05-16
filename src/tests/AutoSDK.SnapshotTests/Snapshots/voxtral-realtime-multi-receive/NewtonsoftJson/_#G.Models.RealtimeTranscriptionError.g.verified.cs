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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RealtimeTranscriptionErrorTypeJsonConverter))]
        public global::G.RealtimeTranscriptionErrorType Type { get; set; }

        /// <summary>
        /// Error detail block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeTranscriptionErrorDetail Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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