//HintName: G.Models.AppPermissionsSingleFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage just a single file.
    /// </summary>
    public enum AppPermissionsSingleFile
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
    public static class AppPermissionsSingleFileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsSingleFile value)
        {
            return value switch
            {
                AppPermissionsSingleFile.Read => "read",
                AppPermissionsSingleFile.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsSingleFile? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsSingleFile.Read,
                "write" => AppPermissionsSingleFile.Write,
                _ => null,
            };
        }
    }
}