//HintName: G.Models.OrganizationMembership.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationMembership
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("active")]
        public string Active { get; set; } = default!;

        /// <summary>
        /// Organization ID<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("organization_id")]
        public int OrganizationId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMembership" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="active">
        /// Included only in responses
        /// </param>
        /// <param name="organizationId">
        /// Organization ID<br/>
        /// Included only in responses
        /// </param>
        public OrganizationMembership(
            string role,
            string active = default!,
            int organizationId = default!)
        {
            this.Active = active;
            this.OrganizationId = organizationId;
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationMembership" /> class.
        /// </summary>
        public OrganizationMembership()
        {
        }
    }
}