//HintName: G.Models.ChapterResponseModelState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the chapter.
    /// </summary>
    public enum ChapterResponseModelState
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Converting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChapterResponseModelStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChapterResponseModelState value)
        {
            return value switch
            {
                ChapterResponseModelState.Default => "default",
                ChapterResponseModelState.Converting => "converting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChapterResponseModelState? ToEnum(string value)
        {
            return value switch
            {
                "default" => ChapterResponseModelState.Default,
                "converting" => ChapterResponseModelState.Converting,
                _ => null,
            };
        }
    }
}