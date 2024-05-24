//HintName: G.Models.DeploymentBranchPolicyNamePatternWithTypeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether this rule targets a branch or tag
    /// <br/>Example: branch
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeploymentBranchPolicyNamePatternWithTypeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branch")]
        Branch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tag")]
        Tag,
    }
}