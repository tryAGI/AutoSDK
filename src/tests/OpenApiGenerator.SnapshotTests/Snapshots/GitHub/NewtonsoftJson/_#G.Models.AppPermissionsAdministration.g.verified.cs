//HintName: G.Models.AppPermissionsAdministration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for repository creation, deletion, settings, teams, and collaborators creation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsAdministration
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