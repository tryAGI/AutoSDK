//HintName: G.Models.AppPermissionsMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsMetadata
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