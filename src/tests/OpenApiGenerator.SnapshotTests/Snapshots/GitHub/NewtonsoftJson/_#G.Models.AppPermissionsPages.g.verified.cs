//HintName: G.Models.AppPermissionsPages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsPages
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