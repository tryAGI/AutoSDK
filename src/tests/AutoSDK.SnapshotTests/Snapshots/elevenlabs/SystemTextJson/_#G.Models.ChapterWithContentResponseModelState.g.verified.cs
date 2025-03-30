//HintName: G.Models.ChapterWithContentResponseModelState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the chapter.
    /// </summary>
    public enum ChapterWithContentResponseModelState
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
    public static class ChapterWithContentResponseModelStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChapterWithContentResponseModelState value)
        {
            return value switch
            {
                ChapterWithContentResponseModelState.Default => "default",
                ChapterWithContentResponseModelState.Converting => "converting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChapterWithContentResponseModelState? ToEnum(string value)
        {
            return value switch
            {
                "default" => ChapterWithContentResponseModelState.Default,
                "converting" => ChapterWithContentResponseModelState.Converting,
                _ => null,
            };
        }
    }
}