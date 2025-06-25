﻿//HintName: G.Models.DeploymentBranchPolicyNamePatternWithTypeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether this rule targets a branch or tag<br/>
    /// Example: branch
    /// </summary>
    public enum DeploymentBranchPolicyNamePatternWithTypeType
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
    public static class DeploymentBranchPolicyNamePatternWithTypeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentBranchPolicyNamePatternWithTypeType value)
        {
            return value switch
            {
                DeploymentBranchPolicyNamePatternWithTypeType.Branch => "branch",
                DeploymentBranchPolicyNamePatternWithTypeType.Tag => "tag",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentBranchPolicyNamePatternWithTypeType? ToEnum(string value)
        {
            return value switch
            {
                "branch" => DeploymentBranchPolicyNamePatternWithTypeType.Branch,
                "tag" => DeploymentBranchPolicyNamePatternWithTypeType.Tag,
                _ => null,
            };
        }
    }
}