//HintName: G.Models.BatchRequestOutputError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// For requests that failed with a non-HTTP error, this will contain more information on the cause of the failure.
    /// </summary>
    public sealed partial class BatchRequestOutputError
    {
        /// <summary>
        /// A machine-readable error code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutputError" /> class.
        /// </summary>
        /// <param name="code">
        /// A machine-readable error code.
        /// </param>
        /// <param name="message">
        /// A human-readable error message.
        /// </param>
        public BatchRequestOutputError(
            string? code,
            string? message)
        {
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestOutputError" /> class.
        /// </summary>
        public BatchRequestOutputError()
        {
        }
    }
}