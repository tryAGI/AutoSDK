//HintName: G.Models.AppPermissionsStatuses.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for commit statuses.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsStatuses
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