//HintName: G.Models.PromptImproveResponsePromptGeneration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptImproveResponsePromptGeneration
    {
        /// <summary>
        /// The improved prompt.<br/>
        /// Default Value: The improved prompt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// API Credits Cost for Random Prompt Generation. Available for Production API Users.<br/>
        /// Default Value: 4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiCreditCost")]
        public int? ApiCreditCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptImproveResponsePromptGeneration" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The improved prompt.<br/>
        /// Default Value: The improved prompt.
        /// </param>
        /// <param name="apiCreditCost">
        /// API Credits Cost for Random Prompt Generation. Available for Production API Users.<br/>
        /// Default Value: 4
        /// </param>
        public PromptImproveResponsePromptGeneration(
            string? prompt,
            int? apiCreditCost)
        {
            this.Prompt = prompt;
            this.ApiCreditCost = apiCreditCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptImproveResponsePromptGeneration" /> class.
        /// </summary>
        public PromptImproveResponsePromptGeneration()
        {
        }
    }
}