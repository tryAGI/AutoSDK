//HintName: G.Models.AclListOrgObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type that the ACL applies to
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AclListOrgObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="group")]
        Group,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="org_member")]
        OrgMember,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="org_project")]
        OrgProject,
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
        [global::System.Runtime.Serialization.EnumMember(Value="project_log")]
        ProjectLog,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt_session")]
        PromptSession,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="role")]
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