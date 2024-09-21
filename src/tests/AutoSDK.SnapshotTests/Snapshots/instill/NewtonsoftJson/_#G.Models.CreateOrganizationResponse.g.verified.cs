//HintName: G.Models.CreateOrganizationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CreateOrganizationResponse contains the created organization.
    /// </summary>
    public sealed partial class CreateOrganizationResponse
    {
        /// <summary>
        /// The organization resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}