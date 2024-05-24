//HintName: G.Models.AppPermissionsCodespaces.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to create, edit, delete, and list Codespaces.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsCodespaces
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