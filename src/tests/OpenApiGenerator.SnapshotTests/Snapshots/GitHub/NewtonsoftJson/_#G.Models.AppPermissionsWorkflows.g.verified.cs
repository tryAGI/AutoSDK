//HintName: G.Models.AppPermissionsWorkflows.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to update GitHub Actions workflow files.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsWorkflows
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsWorkflowsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsWorkflows value)
        {
            return value switch
            {
                AppPermissionsWorkflows.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsWorkflows? ToEnum(string value)
        {
            return value switch
            {
                "write" => AppPermissionsWorkflows.Write,
                _ => null,
            };
        }
    }
}