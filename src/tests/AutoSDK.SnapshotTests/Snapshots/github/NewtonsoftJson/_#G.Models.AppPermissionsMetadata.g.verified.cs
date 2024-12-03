//HintName: G.Models.AppPermissionsMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to search repositories, list collaborators, and access repository metadata.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsMetadata
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
    public static class AppPermissionsMetadataExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsMetadata value)
        {
            return value switch
            {
                AppPermissionsMetadata.Read => "read",
                AppPermissionsMetadata.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsMetadata? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsMetadata.Read,
                "write" => AppPermissionsMetadata.Write,
                _ => null,
            };
        }
    }
}