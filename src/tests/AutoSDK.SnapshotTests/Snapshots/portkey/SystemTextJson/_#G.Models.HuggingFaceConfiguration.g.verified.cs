//HintName: G.Models.HuggingFaceConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HuggingFaceConfiguration
    {
        /// <summary>
        /// Custom Hugging Face base URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("huggingface_base_url")]
        public string? HuggingfaceBaseUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HuggingFaceConfiguration" /> class.
        /// </summary>
        /// <param name="huggingfaceBaseUrl">
        /// Custom Hugging Face base URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HuggingFaceConfiguration(
            string? huggingfaceBaseUrl)
        {
            this.HuggingfaceBaseUrl = huggingfaceBaseUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HuggingFaceConfiguration" /> class.
        /// </summary>
        public HuggingFaceConfiguration()
        {
        }
    }
}