//HintName: G.Models.CustomGuardrailsConfigOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Config container for custom guardrails list
    /// </summary>
    public sealed partial class CustomGuardrailsConfigOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configs")]
        public global::System.Collections.Generic.IList<global::G.CustomGuardrailConfig>? Configs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGuardrailsConfigOutput" /> class.
        /// </summary>
        /// <param name="configs"></param>
        public CustomGuardrailsConfigOutput(
            global::System.Collections.Generic.IList<global::G.CustomGuardrailConfig>? configs)
        {
            this.Configs = configs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomGuardrailsConfigOutput" /> class.
        /// </summary>
        public CustomGuardrailsConfigOutput()
        {
        }
    }
}