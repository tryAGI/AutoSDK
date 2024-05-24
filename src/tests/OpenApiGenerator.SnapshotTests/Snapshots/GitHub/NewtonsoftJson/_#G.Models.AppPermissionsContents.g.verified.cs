//HintName: G.Models.AppPermissionsContents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsContents
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