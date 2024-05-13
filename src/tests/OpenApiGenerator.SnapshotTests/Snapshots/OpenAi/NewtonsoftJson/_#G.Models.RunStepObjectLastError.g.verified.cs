//HintName: G.Models.RunStepObjectLastError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The last error associated with this run step. Will be `null` if there are no errors.
    /// </summary>
    public sealed partial class RunStepObjectLastError
    {
        /// <summary>
        /// One of `server_error` or `rate_limit_exceeded`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public RunStepObjectLastErrorCode Code { get; set; } = default!;

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
    }
}