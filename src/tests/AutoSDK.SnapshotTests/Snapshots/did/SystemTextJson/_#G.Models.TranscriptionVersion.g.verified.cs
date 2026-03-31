//HintName: G.Models.TranscriptionVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TranscriptionVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        Original,
        /// <summary>
        /// 
        /// </summary>
        Shortened,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionVersion value)
        {
            return value switch
            {
                TranscriptionVersion.Edit => "edit",
                TranscriptionVersion.Original => "original",
                TranscriptionVersion.Shortened => "shortened",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionVersion? ToEnum(string value)
        {
            return value switch
            {
                "edit" => TranscriptionVersion.Edit,
                "original" => TranscriptionVersion.Original,
                "shortened" => TranscriptionVersion.Shortened,
                _ => null,
            };
        }
    }
}