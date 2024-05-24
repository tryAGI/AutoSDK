//HintName: G.Models.CodespacesOrgSecretVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of repositories in the organization that the secret is visible to
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodespacesOrgSecretVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="selected")]
        Selected,
    }
}