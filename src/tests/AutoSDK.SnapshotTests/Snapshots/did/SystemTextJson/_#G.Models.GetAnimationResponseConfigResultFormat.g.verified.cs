//HintName: G.Models.GetAnimationResponseConfigResultFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// the file format of the animated video result
    /// </summary>
    public enum GetAnimationResponseConfigResultFormat
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
    public static class GetAnimationResponseConfigResultFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAnimationResponseConfigResultFormat value)
        {
            return value switch
            {
                GetAnimationResponseConfigResultFormat.Mov => "mov",
                GetAnimationResponseConfigResultFormat.Mp4 => "mp4",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAnimationResponseConfigResultFormat? ToEnum(string value)
        {
            return value switch
            {
                "mov" => GetAnimationResponseConfigResultFormat.Mov,
                "mp4" => GetAnimationResponseConfigResultFormat.Mp4,
                _ => null,
            };
        }
    }
}