//HintName: G.Models.ScoreSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreSource
    {
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Eval,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreSource value)
        {
            return value switch
            {
                ScoreSource.Annotation => "ANNOTATION",
                ScoreSource.Api => "API",
                ScoreSource.Eval => "EVAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreSource? ToEnum(string value)
        {
            return value switch
            {
                "ANNOTATION" => ScoreSource.Annotation,
                "API" => ScoreSource.Api,
                "EVAL" => ScoreSource.Eval,
                _ => null,
            };
        }
    }
}