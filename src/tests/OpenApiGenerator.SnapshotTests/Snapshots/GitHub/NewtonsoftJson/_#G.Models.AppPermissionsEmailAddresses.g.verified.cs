//HintName: G.Models.AppPermissionsEmailAddresses.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage the email addresses belonging to a user.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsEmailAddresses
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