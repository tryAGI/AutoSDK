//HintName: G.Models.DeleteCallResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteCallResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DeleteCallResponseStatusJsonConverter))]
        public global::G.DeleteCallResponseStatus? Status { get; set; }

        /// <summary>
        /// Example: Invalid request format, please check API reference.
        /// </summary>
        /// <example>Invalid request format, please check API reference.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCallResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Invalid request format, please check API reference.
        /// </param>
        public DeleteCallResponse(
            global::G.DeleteCallResponseStatus? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteCallResponse" /> class.
        /// </summary>
        public DeleteCallResponse()
        {
        }
    }
}