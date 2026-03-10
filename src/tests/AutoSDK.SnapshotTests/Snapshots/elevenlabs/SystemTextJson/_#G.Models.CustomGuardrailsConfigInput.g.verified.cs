//HintName: G.Models.CustomGuardrailsConfigInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Config container for custom guardrails list
    /// </summary>
    public sealed partial class CustomGuardrailsConfigInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        public global::System.Collections.Generic.IList<global::G.CustomGuardrailConfig>? Configs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGuardrailsConfigInput" /> class.
        /// </summary>
        /// <param name="configs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomGuardrailsConfigInput(
            global::System.Collections.Generic.IList<global::G.CustomGuardrailConfig>? configs)
        {
            this.Configs = configs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGuardrailsConfigInput" /> class.
        /// </summary>
        public CustomGuardrailsConfigInput()
        {
        }
    }
}