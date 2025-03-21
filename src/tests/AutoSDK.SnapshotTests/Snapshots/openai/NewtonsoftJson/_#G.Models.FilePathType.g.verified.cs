//HintName: G.Models.FilePathType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the file path. Always `file_path`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilePathType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="file_path")]
        FilePath,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FilePathTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilePathType value)
        {
            return value switch
            {
                FilePathType.FilePath => "file_path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilePathType? ToEnum(string value)
        {
            return value switch
            {
                "file_path" => FilePathType.FilePath,
                _ => null,
            };
        }
    }
}