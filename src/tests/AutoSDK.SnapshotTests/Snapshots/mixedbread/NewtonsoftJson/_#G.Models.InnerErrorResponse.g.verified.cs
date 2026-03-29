//HintName: G.Models.InnerErrorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Inner Error Pydantic Response Service Message
    /// </summary>
    public sealed partial class InnerErrorResponse
    {
        /// <summary>
        /// The error message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The error code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public int Code { get; set; } = default!;

        /// <summary>
        /// The error type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InnerErrorResponse" /> class.
        /// </summary>
        /// <param name="message">
        /// The error message
        /// </param>
        /// <param name="code">
        /// The error code
        /// </param>
        /// <param name="type">
        /// The error type
        /// </param>
        public InnerErrorResponse(
            string message,
            int code,
            string type)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Code = code;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InnerErrorResponse" /> class.
        /// </summary>
        public InnerErrorResponse()
        {
        }
    }
}