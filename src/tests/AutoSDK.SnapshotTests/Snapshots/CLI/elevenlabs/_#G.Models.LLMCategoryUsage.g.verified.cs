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
        [global::System.Text.Json.Serialization.JsonPropertyName("irreversible_generation")]
        public global::G.LLMUsageOutput? IrreversibleGeneration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("initiated_generation")]
        public global::G.LLMUsageOutput? InitiatedGeneration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMCategoryUsage" /> class.
        /// </summary>
        /// <param name="irreversibleGeneration"></param>
        /// <param name="initiatedGeneration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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