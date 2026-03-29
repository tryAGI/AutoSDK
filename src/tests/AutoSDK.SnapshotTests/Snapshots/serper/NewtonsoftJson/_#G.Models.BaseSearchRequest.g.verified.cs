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
        [global::Newtonsoft.Json.JsonProperty("q", Required = global::Newtonsoft.Json.Required.Always)]
        public string Q { get; set; } = default!;

        /// <summary>
        /// Country code for localized results (ISO 3166-1 alpha-2).<br/>
        /// Example: us
        /// </summary>
        /// <example>us</example>
        [global::Newtonsoft.Json.JsonProperty("gl")]
        public string? Gl { get; set; }

        /// <summary>
        /// Language code for the interface language (ISO 639-1).<br/>
        /// Example: en
        /// </summary>
        /// <example>en</example>
        [global::Newtonsoft.Json.JsonProperty("hl")]
        public string? Hl { get; set; }

        /// <summary>
        /// Number of results to return.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num")]
        public int? Num { get; set; }

        /// <summary>
        /// Page number for pagination.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Whether to autocorrect the query spelling.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autocorrect")]
        public bool? Autocorrect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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