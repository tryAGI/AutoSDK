//HintName: G.Models.AppPermissionsStarring.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to list and manage repositories a user is starring.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsStarring
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