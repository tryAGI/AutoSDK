//HintName: G.Models.CreateConversationFlowResponse4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConversationFlowResponse4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.CreateConversationFlowResponseStatus4? Status { get; set; }

        /// <summary>
        /// Example: Account rate limited, please throttle your requests.
        /// </summary>
        /// <example>Account rate limited, please throttle your requests.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationFlowResponse4" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Account rate limited, please throttle your requests.
        /// </param>
        public CreateConversationFlowResponse4(
            global::G.CreateConversationFlowResponseStatus4? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationFlowResponse4" /> class.
        /// </summary>
        public CreateConversationFlowResponse4()
        {
        }
    }
}