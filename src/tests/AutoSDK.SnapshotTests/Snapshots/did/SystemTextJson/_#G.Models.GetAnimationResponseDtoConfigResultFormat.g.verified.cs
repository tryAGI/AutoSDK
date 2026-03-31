//HintName: G.Models.GetAnimationResponseDtoConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the file format of the animated video result
    /// </summary>
    public enum GetAnimationResponseDtoConfigResultFormat
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
    public static class GetAnimationResponseDtoConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnimationResponseDtoConfigResultFormat value)
        {
            return value switch
            {
                GetAnimationResponseDtoConfigResultFormat.Mov => "mov",
                GetAnimationResponseDtoConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnimationResponseDtoConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => GetAnimationResponseDtoConfigResultFormat.Mov,
                "mp4" => GetAnimationResponseDtoConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}