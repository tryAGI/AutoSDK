//HintName: G.Models.FileCreateFromUrlStorageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FileCreateFromUrlStorageType
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
    public static class FileCreateFromUrlStorageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileCreateFromUrlStorageType value)
        {
            return value switch
            {
                FileCreateFromUrlStorageType.Ephemeral => "ephemeral",
                FileCreateFromUrlStorageType.Permanent => "permanent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileCreateFromUrlStorageType? ToEnum(string value)
        {
            return value switch
            {
                "ephemeral" => FileCreateFromUrlStorageType.Ephemeral,
                "permanent" => FileCreateFromUrlStorageType.Permanent,
                _ => null,
            };
        }
    }
}