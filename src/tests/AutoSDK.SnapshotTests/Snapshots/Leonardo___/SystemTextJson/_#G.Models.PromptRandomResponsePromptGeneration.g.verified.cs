//HintName: G.Models.PromptRandomResponsePromptGeneration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptRandomResponsePromptGeneration
    {
        /// <summary>
        /// The random prompt generated.<br/>
        /// Default Value: The random prompt generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// API Credits Cost for Random Prompt Generation. Available for Production API Users.<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditCost")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptRandomResponsePromptGeneration" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The random prompt generated.<br/>
        /// Default Value: The random prompt generated.
        /// </param>
        /// <param name="apiCreditCost">
        /// API Credits Cost for Random Prompt Generation. Available for Production API Users.<br/>
        /// Default Value: 4
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PromptRandomResponsePromptGeneration(
            string? prompt,
            int? apiCreditCost)
        {
            this.Prompt = prompt;
            this.ApiCreditCost = apiCreditCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptRandomResponsePromptGeneration" /> class.
        /// </summary>
        public PromptRandomResponsePromptGeneration()
        {
        }
    }
}