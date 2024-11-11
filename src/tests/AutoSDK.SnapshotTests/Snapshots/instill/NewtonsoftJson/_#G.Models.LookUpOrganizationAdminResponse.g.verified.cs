//HintName: G.Models.LookUpOrganizationAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LookUpOrganizationAdminResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LookUpOrganizationAdminResponse" /> class.
        /// </summary>
        /// <param name="organization"></param>
        public LookUpOrganizationAdminResponse(
            global::G.Organization? organization)
        {
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LookUpOrganizationAdminResponse" /> class.
        /// </summary>
        public LookUpOrganizationAdminResponse()
        {
        }
    }
}