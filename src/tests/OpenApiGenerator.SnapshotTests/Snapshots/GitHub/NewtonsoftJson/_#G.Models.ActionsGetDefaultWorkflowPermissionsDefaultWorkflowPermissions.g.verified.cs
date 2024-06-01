//HintName: G.Models.ActionsGetDefaultWorkflowPermissionsDefaultWorkflowPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default workflow permissions granted to the GITHUB_TOKEN when running workflows.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsGetDefaultWorkflowPermissionsDefaultWorkflowPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsGetDefaultWorkflowPermissionsDefaultWorkflowPermissionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsGetDefaultWorkflowPermissionsDefaultWorkflowPermissions value)
        {
            return value switch
            {
                ActionsGetDefaultWorkflowPermissionsDefaultWorkflowPermissions.Read => "read",
                ActionsGetDefaultWorkflowPermissionsDefaultWorkflowPermissions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsGetDefaultWorkflowPermissionsDefaultWorkflowPermissions ToEnum(string value)
        {
            return value switch
            {
                "read" => ActionsGetDefaultWorkflowPermissionsDefaultWorkflowPermissions.Read,
                "write" => ActionsGetDefaultWorkflowPermissionsDefaultWorkflowPermissions.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}