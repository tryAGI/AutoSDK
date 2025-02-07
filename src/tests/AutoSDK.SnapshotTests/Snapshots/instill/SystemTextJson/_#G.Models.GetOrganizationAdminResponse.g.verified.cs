//HintName: G.Models.GetOrganizationAdminResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrganizationAdminResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::G.Organization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationAdminResponse" /> class.
        /// </summary>
        /// <param name="organization"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrganizationAdminResponse(
            global::G.Organization? organization)
        {
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrganizationAdminResponse" /> class.
        /// </summary>
        public GetOrganizationAdminResponse()
        {
        }
    }
}