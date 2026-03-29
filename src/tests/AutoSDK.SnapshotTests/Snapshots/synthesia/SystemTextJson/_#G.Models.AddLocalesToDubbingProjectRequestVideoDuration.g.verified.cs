//HintName: G.Models.AddLocalesToDubbingProjectRequestVideoDuration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The duration of the video to create.<br/>
    /// Default Value: adaptive<br/>
    /// Example: adaptive
    /// </summary>
    public enum AddLocalesToDubbingProjectRequestVideoDuration
    {
        /// <summary>
        /// 
        /// </summary>
        Adaptive,
        /// <summary>
        /// 
        /// </summary>
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AddLocalesToDubbingProjectRequestVideoDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AddLocalesToDubbingProjectRequestVideoDuration value)
        {
            return value switch
            {
                AddLocalesToDubbingProjectRequestVideoDuration.Adaptive => "adaptive",
                AddLocalesToDubbingProjectRequestVideoDuration.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AddLocalesToDubbingProjectRequestVideoDuration? ToEnum(string value)
        {
            return value switch
            {
                "adaptive" => AddLocalesToDubbingProjectRequestVideoDuration.Adaptive,
                "original" => AddLocalesToDubbingProjectRequestVideoDuration.Original,
                _ => null,
            };
        }
    }
}