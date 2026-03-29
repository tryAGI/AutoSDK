//HintName: G.Models.CreateAgentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateAgentRequestPrompt Prompt { get; set; } = default!;

        /// <summary>
        /// Set to an explicit model ID for launch requests, or use "default" to use the configured default model. When omitted, Cursor resolves your user default model, then your team default model, then a system default.<br/>
        /// Example: claude-4-sonnet
        /// </summary>
        /// <example>claude-4-sonnet</example>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateAgentRequestSource Source { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public global::G.CreateAgentRequestTarget? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook")]
        public global::G.CreateAgentRequestWebhook? Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="source"></param>
        /// <param name="model">
        /// Set to an explicit model ID for launch requests, or use "default" to use the configured default model. When omitted, Cursor resolves your user default model, then your team default model, then a system default.<br/>
        /// Example: claude-4-sonnet
        /// </param>
        /// <param name="target"></param>
        /// <param name="webhook"></param>
        public CreateAgentRequest(
            global::G.CreateAgentRequestPrompt prompt,
            global::G.CreateAgentRequestSource source,
            string? model,
            global::G.CreateAgentRequestTarget? target,
            global::G.CreateAgentRequestWebhook? webhook)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Model = model;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Target = target;
            this.Webhook = webhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        public CreateAgentRequest()
        {
        }
    }
}