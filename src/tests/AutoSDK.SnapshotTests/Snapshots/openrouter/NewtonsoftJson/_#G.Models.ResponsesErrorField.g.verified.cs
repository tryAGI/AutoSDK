//HintName: G.Models.ResponsesErrorField.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error information returned from the API
    /// </summary>
    public sealed partial class ResponsesErrorField
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponsesErrorFieldCode Code { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesErrorField" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public ResponsesErrorField(
            global::G.ResponsesErrorFieldCode code,
            string message)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesErrorField" /> class.
        /// </summary>
        public ResponsesErrorField()
        {
        }
    }
}