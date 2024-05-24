//HintName: G.Models.AppPermissionsPackages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for packages published to GitHub Packages.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsPackages
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