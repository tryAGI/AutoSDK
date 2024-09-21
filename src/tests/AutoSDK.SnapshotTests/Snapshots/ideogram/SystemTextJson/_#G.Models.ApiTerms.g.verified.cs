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
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TermsId { get; set; }

        /// <summary>
        /// The URL where the terms are hosted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TermsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}