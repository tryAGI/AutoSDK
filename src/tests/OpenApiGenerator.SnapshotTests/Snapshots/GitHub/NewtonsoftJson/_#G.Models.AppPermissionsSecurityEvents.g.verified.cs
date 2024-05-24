//HintName: G.Models.AppPermissionsSecurityEvents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view and manage security events like code scanning alerts.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsSecurityEvents
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