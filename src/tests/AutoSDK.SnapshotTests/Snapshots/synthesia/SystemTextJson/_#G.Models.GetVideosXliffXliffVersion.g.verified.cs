//HintName: G.Models.GetVideosXliffXliffVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetVideosXliffXliffVersion
    {
        /// <summary>
        /// 
        /// </summary>
        x12,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetVideosXliffXliffVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetVideosXliffXliffVersion value)
        {
            return value switch
            {
                GetVideosXliffXliffVersion.x12 => "1.2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetVideosXliffXliffVersion? ToEnum(string value)
        {
            return value switch
            {
                "1.2" => GetVideosXliffXliffVersion.x12,
                _ => null,
            };
        }
    }
}