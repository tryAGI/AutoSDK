//HintName: G.Models.GetCrawlStatusResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCrawlStatusResponse
    {
        /// <summary>
        /// Example: Payment required to access this resource.
        /// </summary>
        /// <example>Payment required to access this resource.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCrawlStatusResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Payment required to access this resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCrawlStatusResponse(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCrawlStatusResponse" /> class.
        /// </summary>
        public GetCrawlStatusResponse()
        {
        }
    }
}