//HintName: G.Models.CreateClipStreamRequestConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result<br/>
    /// Default Value: mp4
    /// </summary>
    public enum CreateClipStreamRequestConfigResultFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Mov,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateClipStreamRequestConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipStreamRequestConfigResultFormat value)
        {
            return value switch
            {
                CreateClipStreamRequestConfigResultFormat.Mov => "mov",
                CreateClipStreamRequestConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipStreamRequestConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateClipStreamRequestConfigResultFormat.Mov,
                "mp4" => CreateClipStreamRequestConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}