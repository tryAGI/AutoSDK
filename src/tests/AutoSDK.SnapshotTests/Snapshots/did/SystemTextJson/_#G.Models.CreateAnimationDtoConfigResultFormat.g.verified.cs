//HintName: G.Models.CreateAnimationDtoConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the file format of the animated video result
    /// </summary>
    public enum CreateAnimationDtoConfigResultFormat
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
    public static class CreateAnimationDtoConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnimationDtoConfigResultFormat value)
        {
            return value switch
            {
                CreateAnimationDtoConfigResultFormat.Mov => "mov",
                CreateAnimationDtoConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnimationDtoConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => CreateAnimationDtoConfigResultFormat.Mov,
                "mp4" => CreateAnimationDtoConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}