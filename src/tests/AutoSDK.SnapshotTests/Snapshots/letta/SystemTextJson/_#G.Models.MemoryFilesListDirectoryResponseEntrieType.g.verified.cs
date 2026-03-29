//HintName: G.Models.MemoryFilesListDirectoryResponseEntrieType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MemoryFilesListDirectoryResponseEntrieType
    {
        /// <summary>
        /// 
        /// </summary>
        Directory,
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MemoryFilesListDirectoryResponseEntrieTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MemoryFilesListDirectoryResponseEntrieType value)
        {
            return value switch
            {
                MemoryFilesListDirectoryResponseEntrieType.Directory => "directory",
                MemoryFilesListDirectoryResponseEntrieType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MemoryFilesListDirectoryResponseEntrieType? ToEnum(string value)
        {
            return value switch
            {
                "directory" => MemoryFilesListDirectoryResponseEntrieType.Directory,
                "file" => MemoryFilesListDirectoryResponseEntrieType.File,
                _ => null,
            };
        }
    }
}