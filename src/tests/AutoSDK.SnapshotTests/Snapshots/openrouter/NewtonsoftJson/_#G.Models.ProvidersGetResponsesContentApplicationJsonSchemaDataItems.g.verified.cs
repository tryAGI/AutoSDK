//HintName: G.Models.ProvidersGetResponsesContentApplicationJsonSchemaDataItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProvidersGetResponsesContentApplicationJsonSchemaDataItems
    {
        /// <summary>
        /// Display name of the provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// URL-friendly identifier for the provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// URL to the provider's privacy policy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy_policy_url")]
        public string? PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// URL to the provider's terms of service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("terms_of_service_url")]
        public string? TermsOfServiceUrl { get; set; }

        /// <summary>
        /// URL to the provider's status page
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_page_url")]
        public string? StatusPageUrl { get; set; }

        /// <summary>
        /// ISO 3166-1 Alpha-2 country code of the provider headquarters
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headquarters")]
        public global::G.OneOf<global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters?, object>? Headquarters { get; set; }

        /// <summary>
        /// ISO 3166-1 Alpha-2 country codes of the provider datacenter locations
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("datacenters")]
        public global::System.Collections.Generic.IList<global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems>? Datacenters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvidersGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        /// <param name="name">
        /// Display name of the provider
        /// </param>
        /// <param name="slug">
        /// URL-friendly identifier for the provider
        /// </param>
        /// <param name="privacyPolicyUrl">
        /// URL to the provider's privacy policy
        /// </param>
        /// <param name="termsOfServiceUrl">
        /// URL to the provider's terms of service
        /// </param>
        /// <param name="statusPageUrl">
        /// URL to the provider's status page
        /// </param>
        /// <param name="headquarters">
        /// ISO 3166-1 Alpha-2 country code of the provider headquarters
        /// </param>
        /// <param name="datacenters">
        /// ISO 3166-1 Alpha-2 country codes of the provider datacenter locations
        /// </param>
        public ProvidersGetResponsesContentApplicationJsonSchemaDataItems(
            string name,
            string slug,
            string? privacyPolicyUrl,
            string? termsOfServiceUrl,
            string? statusPageUrl,
            global::G.OneOf<global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsHeadquarters?, object>? headquarters,
            global::System.Collections.Generic.IList<global::G.ProvidersGetResponsesContentApplicationJsonSchemaDataItemsDatacentersItems>? datacenters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.PrivacyPolicyUrl = privacyPolicyUrl;
            this.TermsOfServiceUrl = termsOfServiceUrl;
            this.StatusPageUrl = statusPageUrl;
            this.Headquarters = headquarters;
            this.Datacenters = datacenters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvidersGetResponsesContentApplicationJsonSchemaDataItems" /> class.
        /// </summary>
        public ProvidersGetResponsesContentApplicationJsonSchemaDataItems()
        {
        }
    }
}