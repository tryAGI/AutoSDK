//HintName: G.Models.ErrorDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorDTO
    {
        /// <summary>
        /// Error code<br/>
        /// Example: 400
        /// </summary>
        /// <example>400</example>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public int Code { get; set; } = default!;

        /// <summary>
        /// Error message<br/>
        /// Example: Bad Request
        /// </summary>
        /// <example>Bad Request</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDTO" /> class.
        /// </summary>
        /// <param name="code">
        /// Error code<br/>
        /// Example: 400
        /// </param>
        /// <param name="message">
        /// Error message<br/>
        /// Example: Bad Request
        /// </param>
        public ErrorDTO(
            int code,
            string message)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDTO" /> class.
        /// </summary>
        public ErrorDTO()
        {
        }
    }
}