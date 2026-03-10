//HintName: G.Models.PromptInjectionGuardrail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptInjectionGuardrail
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInjectionGuardrail" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Default Value: false
        /// </param>
        public PromptInjectionGuardrail(
            bool? isEnabled)
        {
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInjectionGuardrail" /> class.
        /// </summary>
        public PromptInjectionGuardrail()
        {
        }
    }
}