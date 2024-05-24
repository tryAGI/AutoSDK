//HintName: G.Models.AppPermissionsActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for GitHub Actions workflows, workflow runs, and artifacts.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsActions
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