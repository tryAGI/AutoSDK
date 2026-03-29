//HintName: G.Models.CreateResponseResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An error object if the response failed.
    /// </summary>
    public sealed partial class CreateResponseResponseError
    {
        /// <summary>
        /// The error code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// A human-readable error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseResponseError" /> class.
        /// </summary>
        /// <param name="code">
        /// The error code.
        /// </param>
        /// <param name="message">
        /// A human-readable error message.
        /// </param>
        public CreateResponseResponseError(
            string code,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponseResponseError" /> class.
        /// </summary>
        public CreateResponseResponseError()
        {
        }
    }
}