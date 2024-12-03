//HintName: G.Models.ActionsDefaultWorkflowPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The default workflow permissions granted to the GITHUB_TOKEN when running workflows.
    /// </summary>
    public enum ActionsDefaultWorkflowPermissions
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
    public static class ActionsDefaultWorkflowPermissionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsDefaultWorkflowPermissions value)
        {
            return value switch
            {
                ActionsDefaultWorkflowPermissions.Read => "read",
                ActionsDefaultWorkflowPermissions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsDefaultWorkflowPermissions? ToEnum(string value)
        {
            return value switch
            {
                "read" => ActionsDefaultWorkflowPermissions.Read,
                "write" => ActionsDefaultWorkflowPermissions.Write,
                _ => null,
            };
        }
    }
}