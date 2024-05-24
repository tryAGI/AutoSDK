//HintName: G.Models.RepositoryRulesetBypassActorActorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of actor that can bypass a ruleset.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RepositoryRulesetBypassActorActorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Integration")]
        Integration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OrganizationAdmin")]
        OrganizationAdmin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RepositoryRole")]
        RepositoryRole,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Team")]
        Team,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DeployKey")]
        DeployKey,
    }
}