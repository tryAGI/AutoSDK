//HintName: G.Models.RunObjectLastError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The last error associated with this run. Will be `null` if there are no errors.
    /// </summary>
    public sealed partial class RunObjectLastError
    {
        /// <summary>
        /// One of `server_error`, `rate_limit_exceeded`, or `invalid_prompt`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RunObjectLastErrorCode Code { get; set; } = default!;

        /// <summary>
        /// A human-readable description of the error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectLastError" /> class.
        /// </summary>
        /// <param name="code">
        /// One of `server_error`, `rate_limit_exceeded`, or `invalid_prompt`.
        /// </param>
        /// <param name="message">
        /// A human-readable description of the error.
        /// </param>
        public RunObjectLastError(
            global::G.RunObjectLastErrorCode code,
            string message)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectLastError" /> class.
        /// </summary>
        public RunObjectLastError()
        {
        }
    }
}