//HintName: G.Models.DeploymentBranchPolicyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether this rule targets a branch or tag.
    /// <br/>Example: branch
    /// </summary>
    public enum DeploymentBranchPolicyType
    {
        /// <summary>
        /// 
        /// </summary>
        Branch,
        /// <summary>
        /// 
        /// </summary>
        Tag,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeploymentBranchPolicyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentBranchPolicyType value)
        {
            return value switch
            {
                DeploymentBranchPolicyType.Branch => "branch",
                DeploymentBranchPolicyType.Tag => "tag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentBranchPolicyType ToEnum(string value)
        {
            return value switch
            {
                "branch" => DeploymentBranchPolicyType.Branch,
                "tag" => DeploymentBranchPolicyType.Tag,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}