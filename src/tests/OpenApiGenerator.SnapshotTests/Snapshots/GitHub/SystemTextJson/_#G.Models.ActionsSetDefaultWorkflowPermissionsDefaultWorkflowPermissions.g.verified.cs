//HintName: G.Models.ActionsSetDefaultWorkflowPermissionsDefaultWorkflowPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default workflow permissions granted to the GITHUB_TOKEN when running workflows.
    /// </summary>
    public enum ActionsSetDefaultWorkflowPermissionsDefaultWorkflowPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsSetDefaultWorkflowPermissionsDefaultWorkflowPermissionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsSetDefaultWorkflowPermissionsDefaultWorkflowPermissions value)
        {
            return value switch
            {
                ActionsSetDefaultWorkflowPermissionsDefaultWorkflowPermissions.Read => "read",
                ActionsSetDefaultWorkflowPermissionsDefaultWorkflowPermissions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsSetDefaultWorkflowPermissionsDefaultWorkflowPermissions ToEnum(string value)
        {
            return value switch
            {
                "read" => ActionsSetDefaultWorkflowPermissionsDefaultWorkflowPermissions.Read,
                "write" => ActionsSetDefaultWorkflowPermissionsDefaultWorkflowPermissions.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}