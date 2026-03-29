//HintName: G.Models.AclListRestrictObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type that the ACL applies to
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AclListRestrictObjectType
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
    public static class AclListRestrictObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AclListRestrictObjectType value)
        {
            return value switch
            {
                AclListRestrictObjectType.Dataset => "dataset",
                AclListRestrictObjectType.Experiment => "experiment",
                AclListRestrictObjectType.Group => "group",
                AclListRestrictObjectType.OrgMember => "org_member",
                AclListRestrictObjectType.OrgProject => "org_project",
                AclListRestrictObjectType.Organization => "organization",
                AclListRestrictObjectType.Project => "project",
                AclListRestrictObjectType.ProjectLog => "project_log",
                AclListRestrictObjectType.Prompt => "prompt",
                AclListRestrictObjectType.PromptSession => "prompt_session",
                AclListRestrictObjectType.Role => "role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AclListRestrictObjectType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => AclListRestrictObjectType.Dataset,
                "experiment" => AclListRestrictObjectType.Experiment,
                "group" => AclListRestrictObjectType.Group,
                "org_member" => AclListRestrictObjectType.OrgMember,
                "org_project" => AclListRestrictObjectType.OrgProject,
                "organization" => AclListRestrictObjectType.Organization,
                "project" => AclListRestrictObjectType.Project,
                "project_log" => AclListRestrictObjectType.ProjectLog,
                "prompt" => AclListRestrictObjectType.Prompt,
                "prompt_session" => AclListRestrictObjectType.PromptSession,
                "role" => AclListRestrictObjectType.Role,
                _ => null,
            };
        }
    }
}