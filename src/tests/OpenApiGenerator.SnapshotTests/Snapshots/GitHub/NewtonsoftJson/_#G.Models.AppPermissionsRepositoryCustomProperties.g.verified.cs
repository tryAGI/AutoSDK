//HintName: G.Models.AppPermissionsRepositoryCustomProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view and edit custom properties for a repository, when allowed by the property.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsRepositoryCustomProperties
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