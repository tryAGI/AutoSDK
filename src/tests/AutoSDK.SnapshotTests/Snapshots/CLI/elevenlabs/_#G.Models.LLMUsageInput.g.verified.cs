﻿//HintName: G.Models.LLMUsageInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMUsageInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_usage")]
        public global::System.Collections.Generic.Dictionary<string, global::G.LLMInputOutputTokensUsage>? ModelUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageInput" /> class.
        /// </summary>
        /// <param name="modelUsage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMUsageInput(
            global::System.Collections.Generic.Dictionary<string, global::G.LLMInputOutputTokensUsage>? modelUsage)
        {
            this.ModelUsage = modelUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageInput" /> class.
        /// </summary>
        public LLMUsageInput()
        {
        }
    }
}