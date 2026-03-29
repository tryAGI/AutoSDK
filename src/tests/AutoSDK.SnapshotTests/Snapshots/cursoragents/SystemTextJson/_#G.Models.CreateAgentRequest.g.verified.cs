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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateAgentRequestPrompt Prompt { get; set; }

        /// <summary>
        /// Set to an explicit model ID for launch requests, or use "default" to use the configured default model. When omitted, Cursor resolves your user default model, then your team default model, then a system default.<br/>
        /// Example: claude-4-sonnet
        /// </summary>
        /// <example>claude-4-sonnet</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateAgentRequestSource Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::G.CreateAgentRequestTarget? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::G.CreateAgentRequestWebhook? Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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