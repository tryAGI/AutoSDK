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
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; } = "The improved prompt.";

        /// <summary>
        /// API Credits Cost for Random Prompt Generation. Available for Production API Users.<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditCost")]
        public int ApiCreditCost { get; set; } = 4;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}