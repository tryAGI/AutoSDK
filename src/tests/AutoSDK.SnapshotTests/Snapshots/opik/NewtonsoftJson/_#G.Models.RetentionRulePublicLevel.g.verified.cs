//HintName: G.Models.RetentionRulePublicLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Computed from projectId and organizationLevel<br/>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RetentionRulePublicLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace")]
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