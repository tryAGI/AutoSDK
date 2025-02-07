//HintName: G.Models.PromptRandomResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptRandomResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptGeneration")]
        public global::G.PromptRandomResponsePromptGeneration? PromptGeneration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptRandomResponse" /> class.
        /// </summary>
        /// <param name="promptGeneration"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptRandomResponse(
            global::G.PromptRandomResponsePromptGeneration? promptGeneration)
        {
            this.PromptGeneration = promptGeneration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptRandomResponse" /> class.
        /// </summary>
        public PromptRandomResponse()
        {
        }
    }
}