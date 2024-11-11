//HintName: G.Models.PromptImproveResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptImproveResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptGeneration")]
        public global::G.PromptImproveResponsePromptGeneration? PromptGeneration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptImproveResponse" /> class.
        /// </summary>
        /// <param name="promptGeneration"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PromptImproveResponse(
            global::G.PromptImproveResponsePromptGeneration? promptGeneration)
        {
            this.PromptGeneration = promptGeneration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptImproveResponse" /> class.
        /// </summary>
        public PromptImproveResponse()
        {
        }
    }
}