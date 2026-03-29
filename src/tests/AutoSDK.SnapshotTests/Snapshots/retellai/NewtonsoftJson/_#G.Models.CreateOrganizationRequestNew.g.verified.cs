//HintName: G.Models.CreateOrganizationRequestNew.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrganizationRequestNew
    {
        /// <summary>
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </summary>
        /// <example>My Organization</example>
        [global::Newtonsoft.Json.JsonProperty("org_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationRequestNew" /> class.
        /// </summary>
        /// <param name="orgName">
        /// Name of the organization<br/>
        /// Example: My Organization
        /// </param>
        public CreateOrganizationRequestNew(
            string orgName)
        {
            this.OrgName = orgName ?? throw new global::System.ArgumentNullException(nameof(orgName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrganizationRequestNew" /> class.
        /// </summary>
        public CreateOrganizationRequestNew()
        {
        }
    }
}