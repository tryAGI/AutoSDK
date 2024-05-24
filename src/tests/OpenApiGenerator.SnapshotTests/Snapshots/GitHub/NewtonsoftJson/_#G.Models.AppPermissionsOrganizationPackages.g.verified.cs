//HintName: G.Models.AppPermissionsOrganizationPackages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for organization packages published to GitHub Packages.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationPackages
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