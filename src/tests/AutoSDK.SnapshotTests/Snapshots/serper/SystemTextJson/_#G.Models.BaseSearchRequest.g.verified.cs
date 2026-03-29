//HintName: G.Models.BaseSearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BaseSearchRequest
    {
        /// <summary>
        /// Search query string.<br/>
        /// Example: apple inc
        /// </summary>
        /// <example>apple inc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("q")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Q { get; set; }

        /// <summary>
        /// Country code for localized results (ISO 3166-1 alpha-2).<br/>
        /// Example: us
        /// </summary>
        /// <example>us</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("gl")]
        public string? Gl { get; set; }

        /// <summary>
        /// Language code for the interface language (ISO 639-1).<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hl")]
        public string? Hl { get; set; }

        /// <summary>
        /// Number of results to return.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num")]
        public int? Num { get; set; }

        /// <summary>
        /// Page number for pagination.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Whether to autocorrect the query spelling.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autocorrect")]
        public bool? Autocorrect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchRequest" /> class.
        /// </summary>
        /// <param name="q">
        /// Search query string.<br/>
        /// Example: apple inc
        /// </param>
        /// <param name="gl">
        /// Country code for localized results (ISO 3166-1 alpha-2).<br/>
        /// Example: us
        /// </param>
        /// <param name="hl">
        /// Language code for the interface language (ISO 639-1).<br/>
        /// Example: en
        /// </param>
        /// <param name="num">
        /// Number of results to return.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="page">
        /// Page number for pagination.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="autocorrect">
        /// Whether to autocorrect the query spelling.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseSearchRequest(
            string q,
            string? gl,
            string? hl,
            int? num,
            int? page,
            bool? autocorrect)
        {
            this.Q = q ?? throw new global::System.ArgumentNullException(nameof(q));
            this.Gl = gl;
            this.Hl = hl;
            this.Num = num;
            this.Page = page;
            this.Autocorrect = autocorrect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseSearchRequest" /> class.
        /// </summary>
        public BaseSearchRequest()
        {
        }
    }
}