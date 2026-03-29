//HintName: G.Models.VideoSegmentation0Strategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The segmentation strategy you wish to use.<br/>
    /// **Values**:<br/>
    /// - `fixed`: Creates segments of equal, predetermined length. Use this for consistent timing.<br/>
    /// - `dynamic`: Creates segments of variable length that align with scene boundaries. Use this for content-aware segmentation.
    /// </summary>
    public enum VideoSegmentation0Strategy
    {
        /// <summary>
        /// Creates segments of variable length that align with scene boundaries. Use this for content-aware segmentation.
        /// </summary>
        Dynamic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoSegmentation0StrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoSegmentation0Strategy value)
        {
            return value switch
            {
                VideoSegmentation0Strategy.Dynamic => "dynamic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoSegmentation0Strategy? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => VideoSegmentation0Strategy.Dynamic,
                _ => null,
            };
        }
    }
}