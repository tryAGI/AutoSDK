//HintName: G.Models.EndChatResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndChatResponse2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.EndChatResponseStatus2? Status { get; set; }

        /// <summary>
        /// Example: API key is missing or invalid.
        /// </summary>
        /// <example>API key is missing or invalid.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndChatResponse2" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: API key is missing or invalid.
        /// </param>
        public EndChatResponse2(
            global::G.EndChatResponseStatus2? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndChatResponse2" /> class.
        /// </summary>
        public EndChatResponse2()
        {
        }
    }
}