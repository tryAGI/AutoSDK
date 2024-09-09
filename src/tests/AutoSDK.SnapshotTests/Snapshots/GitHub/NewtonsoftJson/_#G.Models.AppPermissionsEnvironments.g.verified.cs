//HintName: G.Models.AppPermissionsEnvironments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for managing repository environments.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsEnvironments
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
    public static class AppPermissionsEnvironmentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsEnvironments value)
        {
            return value switch
            {
                AppPermissionsEnvironments.Read => "read",
                AppPermissionsEnvironments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsEnvironments? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsEnvironments.Read,
                "write" => AppPermissionsEnvironments.Write,
                _ => null,
            };
        }
    }
}