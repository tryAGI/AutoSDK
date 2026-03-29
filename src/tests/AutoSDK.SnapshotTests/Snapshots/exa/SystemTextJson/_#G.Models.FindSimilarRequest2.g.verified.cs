//HintName: G.Models.FindSimilarRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FindSimilarRequest2
    {
        /// <summary>
        /// The url for which you would like to find similar links.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </summary>
        /// <example>https://arxiv.org/abs/2307.06435</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarRequest2" /> class.
        /// </summary>
        /// <param name="url">
        /// The url for which you would like to find similar links.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindSimilarRequest2(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarRequest2" /> class.
        /// </summary>
        public FindSimilarRequest2()
        {
        }
    }
}