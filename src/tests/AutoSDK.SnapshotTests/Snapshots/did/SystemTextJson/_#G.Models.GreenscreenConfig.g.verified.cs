//HintName: G.Models.GreenscreenConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GreenscreenConfig
    {
        /// <summary>
        /// The chroma key color
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chroma_key")]
        public string? ChromaKey { get; set; }

        /// <summary>
        /// The similarity threshold, determines how closely a pixel's color must match the key color to be made transparent<br/>
        /// Default Value: 0.12F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        public double? Similarity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GreenscreenConfig" /> class.
        /// </summary>
        /// <param name="chromaKey">
        /// The chroma key color
        /// </param>
        /// <param name="similarity">
        /// The similarity threshold, determines how closely a pixel's color must match the key color to be made transparent<br/>
        /// Default Value: 0.12F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GreenscreenConfig(
            string? chromaKey,
            double? similarity)
        {
            this.ChromaKey = chromaKey;
            this.Similarity = similarity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GreenscreenConfig" /> class.
        /// </summary>
        public GreenscreenConfig()
        {
        }
    }
}