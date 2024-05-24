//HintName: G.Models.AppPermissionsInteractionLimits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view and manage interaction limits on a repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsInteractionLimits
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