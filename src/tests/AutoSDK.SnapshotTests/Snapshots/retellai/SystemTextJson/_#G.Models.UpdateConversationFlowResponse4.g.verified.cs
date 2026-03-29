//HintName: G.Models.UpdateConversationFlowResponse4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateConversationFlowResponse4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UpdateConversationFlowResponseStatus4JsonConverter))]
        public global::G.UpdateConversationFlowResponseStatus4? Status { get; set; }

        /// <summary>
        /// Example: Account rate limited, please throttle your requests.
        /// </summary>
        /// <example>Account rate limited, please throttle your requests.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationFlowResponse4" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Account rate limited, please throttle your requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateConversationFlowResponse4(
            global::G.UpdateConversationFlowResponseStatus4? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateConversationFlowResponse4" /> class.
        /// </summary>
        public UpdateConversationFlowResponse4()
        {
        }
    }
}