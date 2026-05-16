//HintName: G.Models.RealtimeTranscriptionErrorDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error detail block.
    /// </summary>
    public sealed partial class RealtimeTranscriptionErrorDetail
    {
        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Internal error code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public int Code { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionErrorDetail" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="code">
        /// Internal error code.
        /// </param>
        public RealtimeTranscriptionErrorDetail(
            string message,
            int code)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionErrorDetail" /> class.
        /// </summary>
        public RealtimeTranscriptionErrorDetail()
        {
        }

    }
}