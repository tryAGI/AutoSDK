//HintName: G.Models.RealtimeError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error details.
    /// </summary>
    public sealed partial class RealtimeError
    {
        /// <summary>
        /// Error type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Error code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Human-readable error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Parameter that caused the error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeError" /> class.
        /// </summary>
        /// <param name="type">
        /// Error type.
        /// </param>
        /// <param name="code">
        /// Error code.
        /// </param>
        /// <param name="message">
        /// Human-readable error message.
        /// </param>
        /// <param name="param">
        /// Parameter that caused the error.
        /// </param>
        public RealtimeError(
            string? type,
            string? code,
            string? message,
            string? param)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message;
            this.Param = param;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeError" /> class.
        /// </summary>
        public RealtimeError()
        {
        }
    }
}