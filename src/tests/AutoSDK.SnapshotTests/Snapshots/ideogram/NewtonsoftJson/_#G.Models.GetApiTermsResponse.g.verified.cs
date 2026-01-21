//HintName: G.Models.GetApiTermsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"api_terms":{"terms_url":"terms_url","terms_id":"terms_id"}}
    /// </summary>
    public sealed partial class GetApiTermsResponse
    {
        /// <summary>
        /// Example: {"terms_url":"terms_url","terms_id":"terms_id"}
        /// </summary>
        /// <example>{"terms_url":"terms_url","terms_id":"terms_id"}</example>
        [global::Newtonsoft.Json.JsonProperty("api_terms", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ApiTerms ApiTerms { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiTermsResponse" /> class.
        /// </summary>
        /// <param name="apiTerms">
        /// Example: {"terms_url":"terms_url","terms_id":"terms_id"}
        /// </param>
        public GetApiTermsResponse(
            global::G.ApiTerms apiTerms)
        {
            this.ApiTerms = apiTerms ?? throw new global::System.ArgumentNullException(nameof(apiTerms));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiTermsResponse" /> class.
        /// </summary>
        public GetApiTermsResponse()
        {
        }
    }
}