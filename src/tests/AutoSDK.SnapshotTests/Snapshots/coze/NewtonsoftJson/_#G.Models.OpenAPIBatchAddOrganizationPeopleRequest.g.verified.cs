//HintName: G.Models.OpenAPIBatchAddOrganizationPeopleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIBatchAddOrganizationPeopleRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_people", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PropertiesOrganizationPeopleItems> OrganizationPeople { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIBatchAddOrganizationPeopleRequest" /> class.
        /// </summary>
        /// <param name="organizationPeople"></param>
        public OpenAPIBatchAddOrganizationPeopleRequest(
            global::System.Collections.Generic.IList<global::G.PropertiesOrganizationPeopleItems> organizationPeople)
        {
            this.OrganizationPeople = organizationPeople ?? throw new global::System.ArgumentNullException(nameof(organizationPeople));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIBatchAddOrganizationPeopleRequest" /> class.
        /// </summary>
        public OpenAPIBatchAddOrganizationPeopleRequest()
        {
        }
    }
}