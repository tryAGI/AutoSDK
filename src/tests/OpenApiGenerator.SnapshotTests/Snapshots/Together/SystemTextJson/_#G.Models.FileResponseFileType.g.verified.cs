//HintName: G.Models.FileResponseFileType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: jsonl
    /// </summary>
    public enum FileResponseFileType
    {
        /// <summary>
        /// 
        /// </summary>
        Jsonl,
        /// <summary>
        /// 
        /// </summary>
        Parquet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileResponseFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileResponseFileType value)
        {
            return value switch
            {
                FileResponseFileType.Jsonl => "jsonl",
                FileResponseFileType.Parquet => "parquet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileResponseFileType? ToEnum(string value)
        {
            return value switch
            {
                "jsonl" => FileResponseFileType.Jsonl,
                "parquet" => FileResponseFileType.Parquet,
                _ => null,
            };
        }
    }
}