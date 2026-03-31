//HintName: G.Models.AclObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type that the ACL applies to
    /// </summary>
    public enum AclObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        Group,
        /// <summary>
        /// 
        /// </summary>
        OrgMember,
        /// <summary>
        /// 
        /// </summary>
        OrgProject,
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
        ProjectLog,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        PromptSession,
        /// <summary>
        /// 
        /// </summary>
        Role,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AclObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AclObjectType value)
        {
            return value switch
            {
                AclObjectType.Dataset => "dataset",
                AclObjectType.Experiment => "experiment",
                AclObjectType.Group => "group",
                AclObjectType.OrgMember => "org_member",
                AclObjectType.OrgProject => "org_project",
                AclObjectType.Organization => "organization",
                AclObjectType.Project => "project",
                AclObjectType.ProjectLog => "project_log",
                AclObjectType.Prompt => "prompt",
                AclObjectType.PromptSession => "prompt_session",
                AclObjectType.Role => "role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AclObjectType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => AclObjectType.Dataset,
                "experiment" => AclObjectType.Experiment,
                "group" => AclObjectType.Group,
                "org_member" => AclObjectType.OrgMember,
                "org_project" => AclObjectType.OrgProject,
                "organization" => AclObjectType.Organization,
                "project" => AclObjectType.Project,
                "project_log" => AclObjectType.ProjectLog,
                "prompt" => AclObjectType.Prompt,
                "prompt_session" => AclObjectType.PromptSession,
                "role" => AclObjectType.Role,
                _ => null,
            };
        }
    }
}