//HintName: G.Models.ListConversationFlowComponentsV2Response5.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListConversationFlowComponentsV2Response5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ListConversationFlowComponentsV2ResponseStatus3JsonConverter))]
        public global::G.ListConversationFlowComponentsV2ResponseStatus3? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="ListConversationFlowComponentsV2Response5" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Account rate limited, please throttle your requests.
        /// </param>
        public ListConversationFlowComponentsV2Response5(
            global::G.ListConversationFlowComponentsV2ResponseStatus3? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListConversationFlowComponentsV2Response5" /> class.
        /// </summary>
        public ListConversationFlowComponentsV2Response5()
        {
        }
    }
}