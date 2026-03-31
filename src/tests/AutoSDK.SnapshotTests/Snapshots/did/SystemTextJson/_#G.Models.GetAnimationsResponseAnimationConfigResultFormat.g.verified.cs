//HintName: G.Models.GetAnimationsResponseAnimationConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the file format of the animated video result
    /// </summary>
    public enum GetAnimationsResponseAnimationConfigResultFormat
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
    public static class GetAnimationsResponseAnimationConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnimationsResponseAnimationConfigResultFormat value)
        {
            return value switch
            {
                GetAnimationsResponseAnimationConfigResultFormat.Mov => "mov",
                GetAnimationsResponseAnimationConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnimationsResponseAnimationConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => GetAnimationsResponseAnimationConfigResultFormat.Mov,
                "mp4" => GetAnimationsResponseAnimationConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}