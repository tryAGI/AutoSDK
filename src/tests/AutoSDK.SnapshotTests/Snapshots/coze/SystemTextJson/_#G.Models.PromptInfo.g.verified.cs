//HintName: G.Models.PromptInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptInfo
    {
        /// <summary>
        /// 文本prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInfo" /> class.
        /// </summary>
        /// <param name="prompt">
        /// 文本prompt
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptInfo(
            string? prompt)
        {
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptInfo" /> class.
        /// </summary>
        public PromptInfo()
        {
        }
    }
}