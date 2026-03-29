//HintName: G.Models.RetentionRulePublicLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Computed from projectId and organizationLevel<br/>
    /// Included only in responses
    /// </summary>
    public enum RetentionRulePublicLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionRulePublicLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionRulePublicLevel value)
        {
            return value switch
            {
                RetentionRulePublicLevel.Organization => "organization",
                RetentionRulePublicLevel.Project => "project",
                RetentionRulePublicLevel.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionRulePublicLevel? ToEnum(string value)
        {
            return value switch
            {
                "organization" => RetentionRulePublicLevel.Organization,
                "project" => RetentionRulePublicLevel.Project,
                "workspace" => RetentionRulePublicLevel.Workspace,
                _ => null,
            };
        }
    }
}