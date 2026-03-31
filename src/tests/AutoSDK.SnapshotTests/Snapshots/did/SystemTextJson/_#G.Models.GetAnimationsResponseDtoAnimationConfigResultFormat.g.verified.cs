//HintName: G.Models.GetAnimationsResponseDtoAnimationConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the file format of the animated video result
    /// </summary>
    public enum GetAnimationsResponseDtoAnimationConfigResultFormat
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
    public static class GetAnimationsResponseDtoAnimationConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnimationsResponseDtoAnimationConfigResultFormat value)
        {
            return value switch
            {
                GetAnimationsResponseDtoAnimationConfigResultFormat.Mov => "mov",
                GetAnimationsResponseDtoAnimationConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnimationsResponseDtoAnimationConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => GetAnimationsResponseDtoAnimationConfigResultFormat.Mov,
                "mp4" => GetAnimationsResponseDtoAnimationConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}