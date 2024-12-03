//HintName: G.Models.AppPermissionsRepositoryCustomProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view and edit custom properties for a repository, when allowed by the property.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsRepositoryCustomProperties
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
    public static class AppPermissionsRepositoryCustomPropertiesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsRepositoryCustomProperties value)
        {
            return value switch
            {
                AppPermissionsRepositoryCustomProperties.Read => "read",
                AppPermissionsRepositoryCustomProperties.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsRepositoryCustomProperties? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsRepositoryCustomProperties.Read,
                "write" => AppPermissionsRepositoryCustomProperties.Write,
                _ => null,
            };
        }
    }
}