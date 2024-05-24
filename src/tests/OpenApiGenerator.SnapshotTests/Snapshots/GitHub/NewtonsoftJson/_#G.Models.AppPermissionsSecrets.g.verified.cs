//HintName: G.Models.AppPermissionsSecrets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage repository secrets.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsSecrets
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