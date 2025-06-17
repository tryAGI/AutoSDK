//HintName: G.Models.LLMInputOutputTokensUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMInputOutputTokensUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::G.LLMTokensCategoryUsage? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_read")]
        public global::G.LLMTokensCategoryUsage? InputCacheRead { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cache_write")]
        public global::G.LLMTokensCategoryUsage? InputCacheWrite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_total")]
        public global::G.LLMTokensCategoryUsage? OutputTotal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMInputOutputTokensUsage" /> class.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="inputCacheRead"></param>
        /// <param name="inputCacheWrite"></param>
        /// <param name="outputTotal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMInputOutputTokensUsage(
            global::G.LLMTokensCategoryUsage? input,
            global::G.LLMTokensCategoryUsage? inputCacheRead,
            global::G.LLMTokensCategoryUsage? inputCacheWrite,
            global::G.LLMTokensCategoryUsage? outputTotal)
        {
            this.Input = input;
            this.InputCacheRead = inputCacheRead;
            this.InputCacheWrite = inputCacheWrite;
            this.OutputTotal = outputTotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMInputOutputTokensUsage" /> class.
        /// </summary>
        public LLMInputOutputTokensUsage()
        {
        }
    }
}