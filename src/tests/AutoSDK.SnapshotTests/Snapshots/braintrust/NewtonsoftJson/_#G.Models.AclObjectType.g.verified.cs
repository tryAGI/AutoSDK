//HintName: G.Models.AclObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type that the ACL applies to
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AclObjectType
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