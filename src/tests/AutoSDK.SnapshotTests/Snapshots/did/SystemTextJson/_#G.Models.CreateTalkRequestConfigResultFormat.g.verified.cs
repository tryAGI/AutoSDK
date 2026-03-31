//HintName: G.Models.CreateTalkRequestConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the animated result
    /// </summary>
    public enum CreateTalkRequestConfigResultFormat
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
    public static class CreateTalkRequestConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestConfigResultFormat value)
        {
            return value switch
            {
                CreateTalkRequestConfigResultFormat.Mov => "mov",
                CreateTalkRequestConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateTalkRequestConfigResultFormat.Mov,
                "mp4" => CreateTalkRequestConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}