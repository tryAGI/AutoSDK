//HintName: G.Models.AppPermissionsGitSshKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage git SSH keys.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsGitSshKeys
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