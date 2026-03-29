//HintName: G.Models.OrganizationResponseVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationResponseVariant2
    {
        /// <summary>
        /// Unique identifier of the organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationResponseVariant2" /> class.
        /// </summary>
        /// <param name="orgId">
        /// Unique identifier of the organization
        /// </param>
        public OrganizationResponseVariant2(
            string? orgId)
        {
            this.OrgId = orgId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationResponseVariant2" /> class.
        /// </summary>
        public OrganizationResponseVariant2()
        {
        }
    }
}