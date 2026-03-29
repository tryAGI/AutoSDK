//HintName: G.Models.GetBatchScrapeErrorsResponse2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBatchScrapeErrorsResponse2
    {
        /// <summary>
        /// Example: Request rate limit exceeded. Please wait and try again later.
        /// </summary>
        /// <example>Request rate limit exceeded. Please wait and try again later.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBatchScrapeErrorsResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Request rate limit exceeded. Please wait and try again later.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBatchScrapeErrorsResponse2(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBatchScrapeErrorsResponse2" /> class.
        /// </summary>
        public GetBatchScrapeErrorsResponse2()
        {
        }
    }
}