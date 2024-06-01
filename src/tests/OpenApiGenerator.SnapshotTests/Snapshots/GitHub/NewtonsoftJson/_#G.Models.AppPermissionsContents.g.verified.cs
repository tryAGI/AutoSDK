//HintName: G.Models.AppPermissionsContents.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token for repository contents, commits, branches, downloads, releases, and merges.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AppPermissionsContents
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
    public static class AppPermissionsContentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsContents value)
        {
            return value switch
            {
                AppPermissionsContents.Read => "read",
                AppPermissionsContents.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsContents ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsContents.Read,
                "write" => AppPermissionsContents.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}