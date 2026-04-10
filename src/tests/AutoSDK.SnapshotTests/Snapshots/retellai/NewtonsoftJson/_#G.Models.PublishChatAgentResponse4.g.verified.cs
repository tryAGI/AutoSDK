//HintName: G.Models.PublishChatAgentResponse4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublishChatAgentResponse4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PublishChatAgentResponseStatus4JsonConverter))]
        public global::G.PublishChatAgentResponseStatus4? Status { get; set; }

        /// <summary>
        /// Example: Cannot find requested asset under given api key.
        /// </summary>
        /// <example>Cannot find requested asset under given api key.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishChatAgentResponse4" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Cannot find requested asset under given api key.
        /// </param>
        public PublishChatAgentResponse4(
            global::G.PublishChatAgentResponseStatus4? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishChatAgentResponse4" /> class.
        /// </summary>
        public PublishChatAgentResponse4()
        {
        }
    }
}