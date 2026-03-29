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
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_people")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PropertiesOrganizationPeopleItems> OrganizationPeople { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIBatchAddOrganizationPeopleRequest" /> class.
        /// </summary>
        /// <param name="organizationPeople"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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