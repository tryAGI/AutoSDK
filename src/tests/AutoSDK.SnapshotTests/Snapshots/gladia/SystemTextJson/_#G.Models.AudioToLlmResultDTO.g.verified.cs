//HintName: G.Models.AudioToLlmResultDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioToLlmResultDTO
    {
        /// <summary>
        /// The prompt used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// The result of the AI analysis
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public string? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToLlmResultDTO" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt used
        /// </param>
        /// <param name="response">
        /// The result of the AI analysis
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioToLlmResultDTO(
            string? prompt,
            string? response)
        {
            this.Prompt = prompt;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioToLlmResultDTO" /> class.
        /// </summary>
        public AudioToLlmResultDTO()
        {
        }
    }
}