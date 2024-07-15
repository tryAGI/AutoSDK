//HintName: G.Models.ContentDirectoryType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentDirectoryType
    {
        /// <summary>
        /// 
        /// </summary>
        Dir,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Submodule,
        /// <summary>
        /// 
        /// </summary>
        Symlink,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentDirectoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentDirectoryType value)
        {
            return value switch
            {
                ContentDirectoryType.Dir => "dir",
                ContentDirectoryType.File => "file",
                ContentDirectoryType.Submodule => "submodule",
                ContentDirectoryType.Symlink => "symlink",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentDirectoryType? ToEnum(string value)
        {
            return value switch
            {
                "dir" => ContentDirectoryType.Dir,
                "file" => ContentDirectoryType.File,
                "submodule" => ContentDirectoryType.Submodule,
                "symlink" => ContentDirectoryType.Symlink,
                _ => null,
            };
        }
    }
}