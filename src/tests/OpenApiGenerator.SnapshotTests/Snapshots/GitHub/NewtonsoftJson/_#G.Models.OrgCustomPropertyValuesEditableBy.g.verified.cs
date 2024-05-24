//HintName: G.Models.OrgCustomPropertyValuesEditableBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Who can edit the values of the property
    /// <br/>Example: org_actors
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OrgCustomPropertyValuesEditableBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="org_actors")]
        OrgActors,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="org_and_repo_actors")]
        OrgAndRepoActors,
    }
}