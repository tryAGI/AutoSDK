//HintName: G.Models.GuardrailsV1Output.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardrailsV1Output
    {
        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("focus")]
        public global::G.FocusGuardrail? Focus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_injection")]
        public global::G.PromptInjectionGuardrail? PromptInjection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public global::G.ContentGuardrailOutput? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderation")]
        public global::G.ModerationGuardrailOutput? Moderation { get; set; }

        /// <summary>
        /// Container for custom guardrails, matching ModerationGuardrail pattern
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom")]
        public global::G.CustomGuardrailOutput? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsV1Output" /> class.
        /// </summary>
        /// <param name="version">
        /// Default Value: 1
        /// </param>
        /// <param name="focus"></param>
        /// <param name="promptInjection"></param>
        /// <param name="content"></param>
        /// <param name="moderation"></param>
        /// <param name="custom">
        /// Container for custom guardrails, matching ModerationGuardrail pattern
        /// </param>
        public GuardrailsV1Output(
            string? version,
            global::G.FocusGuardrail? focus,
            global::G.PromptInjectionGuardrail? promptInjection,
            global::G.ContentGuardrailOutput? content,
            global::G.ModerationGuardrailOutput? moderation,
            global::G.CustomGuardrailOutput? custom)
        {
            this.Version = version;
            this.Focus = focus;
            this.PromptInjection = promptInjection;
            this.Content = content;
            this.Moderation = moderation;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsV1Output" /> class.
        /// </summary>
        public GuardrailsV1Output()
        {
        }
    }
}