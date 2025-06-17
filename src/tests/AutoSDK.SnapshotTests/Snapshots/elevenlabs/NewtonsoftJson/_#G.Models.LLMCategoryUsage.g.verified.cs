//HintName: G.Models.LLMCategoryUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMCategoryUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("irreversible_generation")]
        public global::G.LLMUsageOutput? IrreversibleGeneration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("initiated_generation")]
        public global::G.LLMUsageOutput? InitiatedGeneration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMCategoryUsage" /> class.
        /// </summary>
        /// <param name="irreversibleGeneration"></param>
        /// <param name="initiatedGeneration"></param>
        public LLMCategoryUsage(
            global::G.LLMUsageOutput? irreversibleGeneration,
            global::G.LLMUsageOutput? initiatedGeneration)
        {
            this.IrreversibleGeneration = irreversibleGeneration;
            this.InitiatedGeneration = initiatedGeneration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMCategoryUsage" /> class.
        /// </summary>
        public LLMCategoryUsage()
        {
        }
    }
}