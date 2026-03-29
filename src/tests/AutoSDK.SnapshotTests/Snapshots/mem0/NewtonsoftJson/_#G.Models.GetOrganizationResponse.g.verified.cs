//HintName: G.Models.GetOrganizationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationResponse
    {
        /// <summary>
        /// Unique identifier for the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Unique organization ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Name of the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Address of the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Contact email for the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contact_email")]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// Phone number of the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phone_number")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Website of the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("website")]
        public string? Website { get; set; }

        /// <summary>
        /// Indicates if the organization is on a paid plan
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_paid_plan")]
        public bool? OnPaidPlan { get; set; }

        /// <summary>
        /// Timestamp of when the organization was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the organization was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Identifier of the organization's owner
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner")]
        public int? Owner { get; set; }

        /// <summary>
        /// List of member identifiers belonging to the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members")]
        public global::System.Collections.Generic.IList<int>? Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the organization.
        /// </param>
        /// <param name="orgId">
        /// Unique organization ID
        /// </param>
        /// <param name="name">
        /// Name of the organization.
        /// </param>
        /// <param name="description">
        /// Description of the organization
        /// </param>
        /// <param name="address">
        /// Address of the organization
        /// </param>
        /// <param name="contactEmail">
        /// Contact email for the organization
        /// </param>
        /// <param name="phoneNumber">
        /// Phone number of the organization
        /// </param>
        /// <param name="website">
        /// Website of the organization
        /// </param>
        /// <param name="onPaidPlan">
        /// Indicates if the organization is on a paid plan
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the organization was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the organization was last updated.
        /// </param>
        /// <param name="owner">
        /// Identifier of the organization's owner
        /// </param>
        /// <param name="members">
        /// List of member identifiers belonging to the organization.
        /// </param>
        public GetOrganizationResponse(
            int? id,
            string? orgId,
            string? name,
            string? description,
            string? address,
            string? contactEmail,
            string? phoneNumber,
            string? website,
            bool? onPaidPlan,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            int? owner,
            global::System.Collections.Generic.IList<int>? members)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.Name = name;
            this.Description = description;
            this.Address = address;
            this.ContactEmail = contactEmail;
            this.PhoneNumber = phoneNumber;
            this.Website = website;
            this.OnPaidPlan = onPaidPlan;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Owner = owner;
            this.Members = members;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationResponse" /> class.
        /// </summary>
        public GetOrganizationResponse()
        {
        }
    }
}