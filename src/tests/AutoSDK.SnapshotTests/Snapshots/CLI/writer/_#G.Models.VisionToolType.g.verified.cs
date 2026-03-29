//HintName: G.Models.VisionToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool.
    /// </summary>
    public enum VisionToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Vision,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VisionToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VisionToolType value)
        {
            return value switch
            {
                VisionToolType.Vision => "vision",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VisionToolType? ToEnum(string value)
        {
            return value switch
            {
                "vision" => VisionToolType.Vision,
                _ => null,
            };
        }
    }
}