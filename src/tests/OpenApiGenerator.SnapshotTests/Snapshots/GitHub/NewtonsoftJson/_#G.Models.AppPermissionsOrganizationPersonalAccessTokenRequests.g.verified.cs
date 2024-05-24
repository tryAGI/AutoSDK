//HintName: G.Models.AppPermissionsOrganizationPersonalAccessTokenRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for viewing and managing fine-grained personal access tokens that have been approved by an organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationPersonalAccessTokenRequests
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }
}