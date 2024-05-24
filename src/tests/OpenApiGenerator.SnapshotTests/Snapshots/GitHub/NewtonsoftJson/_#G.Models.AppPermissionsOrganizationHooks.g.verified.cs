//HintName: G.Models.AppPermissionsOrganizationHooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage the post-receive hooks for an organization.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationHooks
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