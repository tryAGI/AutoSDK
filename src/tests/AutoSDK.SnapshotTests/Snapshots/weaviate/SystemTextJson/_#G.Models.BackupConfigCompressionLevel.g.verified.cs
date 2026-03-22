//HintName: G.Models.BackupConfigCompressionLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Compression level used by compression algorithm<br/>
    /// Default Value: DefaultCompression
    /// </summary>
    public enum BackupConfigCompressionLevel
    {
        /// <summary>
        /// 
        /// </summary>
        BestCompression,
        /// <summary>
        /// 
        /// </summary>
        BestSpeed,
        /// <summary>
        /// 
        /// </summary>
        DefaultCompression,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BackupConfigCompressionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BackupConfigCompressionLevel value)
        {
            return value switch
            {
                BackupConfigCompressionLevel.BestCompression => "BestCompression",
                BackupConfigCompressionLevel.BestSpeed => "BestSpeed",
                BackupConfigCompressionLevel.DefaultCompression => "DefaultCompression",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BackupConfigCompressionLevel? ToEnum(string value)
        {
            return value switch
            {
                "BestCompression" => BackupConfigCompressionLevel.BestCompression,
                "BestSpeed" => BackupConfigCompressionLevel.BestSpeed,
                "DefaultCompression" => BackupConfigCompressionLevel.DefaultCompression,
                _ => null,
            };
        }
    }
}