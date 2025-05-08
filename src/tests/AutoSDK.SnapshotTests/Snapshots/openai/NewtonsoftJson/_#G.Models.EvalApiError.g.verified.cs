//HintName: G.Models.EvalApiError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object representing an error response from the Eval API.
    /// </summary>
    public sealed partial class EvalApiError
    {
        /// <summary>
        /// The error code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// The error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalApiError" /> class.
        /// </summary>
        /// <param name="code">
        /// The error code.
        /// </param>
        /// <param name="message">
        /// The error message.
        /// </param>
        public EvalApiError(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalApiError" /> class.
        /// </summary>
        public EvalApiError()
        {
        }
    }
}