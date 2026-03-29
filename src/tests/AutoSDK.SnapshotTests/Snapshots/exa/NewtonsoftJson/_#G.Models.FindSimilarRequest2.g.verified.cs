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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarRequest2" /> class.
        /// </summary>
        /// <param name="url">
        /// The url for which you would like to find similar links.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </param>
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