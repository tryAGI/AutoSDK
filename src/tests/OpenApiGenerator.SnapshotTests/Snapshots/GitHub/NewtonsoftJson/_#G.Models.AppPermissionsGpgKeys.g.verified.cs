//HintName: G.Models.AppPermissionsGpgKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view and manage GPG keys belonging to a user.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsGpgKeys
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