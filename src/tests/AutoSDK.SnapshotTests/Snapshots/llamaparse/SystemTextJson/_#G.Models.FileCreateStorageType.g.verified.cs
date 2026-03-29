//HintName: G.Models.FileCreateStorageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FileCreateStorageType
    {
        /// <summary>
        /// 
        /// </summary>
        Ephemeral,
        /// <summary>
        /// 
        /// </summary>
        Permanent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileCreateStorageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileCreateStorageType value)
        {
            return value switch
            {
                FileCreateStorageType.Ephemeral => "ephemeral",
                FileCreateStorageType.Permanent => "permanent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileCreateStorageType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => FileCreateStorageType.Ephemeral,
                "permanent" => FileCreateStorageType.Permanent,
                _ => null,
            };
        }
    }
}