//HintName: G.Models.AclListOrgObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type that the ACL applies to
    /// </summary>
    public enum AclListOrgObjectType
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
    public static class AclListOrgObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AclListOrgObjectType value)
        {
            return value switch
            {
                AclListOrgObjectType.Dataset => "dataset",
                AclListOrgObjectType.Experiment => "experiment",
                AclListOrgObjectType.Group => "group",
                AclListOrgObjectType.OrgMember => "org_member",
                AclListOrgObjectType.OrgProject => "org_project",
                AclListOrgObjectType.Organization => "organization",
                AclListOrgObjectType.Project => "project",
                AclListOrgObjectType.ProjectLog => "project_log",
                AclListOrgObjectType.Prompt => "prompt",
                AclListOrgObjectType.PromptSession => "prompt_session",
                AclListOrgObjectType.Role => "role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AclListOrgObjectType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => AclListOrgObjectType.Dataset,
                "experiment" => AclListOrgObjectType.Experiment,
                "group" => AclListOrgObjectType.Group,
                "org_member" => AclListOrgObjectType.OrgMember,
                "org_project" => AclListOrgObjectType.OrgProject,
                "organization" => AclListOrgObjectType.Organization,
                "project" => AclListOrgObjectType.Project,
                "project_log" => AclListOrgObjectType.ProjectLog,
                "prompt" => AclListOrgObjectType.Prompt,
                "prompt_session" => AclListOrgObjectType.PromptSession,
                "role" => AclListOrgObjectType.Role,
                _ => null,
            };
        }
    }
}