//HintName: G.Models.MostExpensiveRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MostExpensiveRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestId", Required = global::Newtonsoft.Json.Required.Always)]
        public string RequestId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completionTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation")]
        public global::G.MostExpensiveRequestConversation? Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MostExpensiveRequest" /> class.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cost"></param>
        /// <param name="model"></param>
        /// <param name="provider"></param>
        /// <param name="createdAt"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="conversation"></param>
        public MostExpensiveRequest(
            string requestId,
            double cost,
            string model,
            string provider,
            string createdAt,
            double promptTokens,
            double completionTokens,
            global::G.MostExpensiveRequestConversation? conversation)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Cost = cost;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.Conversation = conversation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MostExpensiveRequest" /> class.
        /// </summary>
        public MostExpensiveRequest()
        {
        }
    }
}