//HintName: G.Models.PublishChatAgentResponse5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublishChatAgentResponse5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PublishChatAgentResponseStatus5JsonConverter))]
        public global::G.PublishChatAgentResponseStatus5? Status { get; set; }

        /// <summary>
        /// Example: An unexpected server error occurred.
        /// </summary>
        /// <example>An unexpected server error occurred.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishChatAgentResponse5" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: An unexpected server error occurred.
        /// </param>
        public PublishChatAgentResponse5(
            global::G.PublishChatAgentResponseStatus5? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublishChatAgentResponse5" /> class.
        /// </summary>
        public PublishChatAgentResponse5()
        {
        }
    }
}