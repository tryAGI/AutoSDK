//HintName: G.Models.ErrorResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorResponseError
    {
        /// <summary>
        /// A human-readable error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The error type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The error code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable error message.
        /// </param>
        /// <param name="type">
        /// The error type.
        /// </param>
        /// <param name="code">
        /// The error code.
        /// </param>
        public ErrorResponseError(
            string? message,
            string? type,
            string? code)
        {
            this.Message = message;
            this.Type = type;
            this.Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        public ErrorResponseError()
        {
        }
    }
}