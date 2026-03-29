//HintName: G.Models.FolderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FolderType
    {
        /// <summary>
        /// 
        /// </summary>
        Development,
        /// <summary>
        /// 
        /// </summary>
        Library,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FolderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FolderType value)
        {
            return value switch
            {
                FolderType.Development => "development",
                FolderType.Library => "library",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FolderType? ToEnum(string value)
        {
            return value switch
            {
                "development" => FolderType.Development,
                "library" => FolderType.Library,
                _ => null,
            };
        }
    }
}