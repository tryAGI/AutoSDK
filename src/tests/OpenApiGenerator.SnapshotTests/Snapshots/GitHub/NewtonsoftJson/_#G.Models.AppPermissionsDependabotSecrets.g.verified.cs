//HintName: G.Models.AppPermissionsDependabotSecrets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The leve of permission to grant the access token to manage Dependabot secrets.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsDependabotSecrets
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