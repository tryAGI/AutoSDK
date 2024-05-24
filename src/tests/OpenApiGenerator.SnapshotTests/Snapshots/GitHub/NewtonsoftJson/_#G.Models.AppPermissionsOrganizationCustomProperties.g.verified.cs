//HintName: G.Models.AppPermissionsOrganizationCustomProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for custom property management.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationCustomProperties
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
    }
}