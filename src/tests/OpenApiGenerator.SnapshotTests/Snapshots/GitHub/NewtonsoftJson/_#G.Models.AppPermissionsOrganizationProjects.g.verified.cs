//HintName: G.Models.AppPermissionsOrganizationProjects.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage organization projects and projects beta (where available).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsOrganizationProjects
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