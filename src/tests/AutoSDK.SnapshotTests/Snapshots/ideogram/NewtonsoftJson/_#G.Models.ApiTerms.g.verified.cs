//HintName: G.Models.ApiTerms.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiTerms
    {
        /// <summary>
        /// The ID of the terms.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terms_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string TermsId { get; set; } = default!;

        /// <summary>
        /// The URL where the terms are hosted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terms_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string TermsUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}