//HintName: G.Models.AppPermissionsRepositoryHooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage the post-receive hooks for a repository.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsRepositoryHooks
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