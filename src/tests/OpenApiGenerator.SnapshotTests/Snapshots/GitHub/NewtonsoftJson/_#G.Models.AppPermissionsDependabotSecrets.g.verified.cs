//HintName: G.Models.AppPermissionsDependabotSecrets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The leve of permission to grant the access token to manage Dependabot secrets.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsDependabotSecrets
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
    public static class AppPermissionsDependabotSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsDependabotSecrets value)
        {
            return value switch
            {
                AppPermissionsDependabotSecrets.Read => "read",
                AppPermissionsDependabotSecrets.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsDependabotSecrets? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsDependabotSecrets.Read,
                "write" => AppPermissionsDependabotSecrets.Write,
                _ => null,
            };
        }
    }
}