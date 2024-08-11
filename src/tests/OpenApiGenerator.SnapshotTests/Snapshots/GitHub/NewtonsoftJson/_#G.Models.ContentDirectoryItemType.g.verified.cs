//HintName: G.Models.ContentDirectoryItemType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ContentDirectoryItemType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dir")]
        Dir,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file")]
        File,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="submodule")]
        Submodule,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="symlink")]
        Symlink,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentDirectoryItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentDirectoryItemType value)
        {
            return value switch
            {
                ContentDirectoryItemType.Dir => "dir",
                ContentDirectoryItemType.File => "file",
                ContentDirectoryItemType.Submodule => "submodule",
                ContentDirectoryItemType.Symlink => "symlink",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentDirectoryItemType? ToEnum(string value)
        {
            return value switch
            {
                "dir" => ContentDirectoryItemType.Dir,
                "file" => ContentDirectoryItemType.File,
                "submodule" => ContentDirectoryItemType.Submodule,
                "symlink" => ContentDirectoryItemType.Symlink,
                _ => null,
            };
        }
    }
}