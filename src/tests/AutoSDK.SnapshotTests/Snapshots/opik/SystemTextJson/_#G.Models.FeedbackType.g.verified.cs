//HintName: G.Models.FeedbackType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        Numerical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackType value)
        {
            return value switch
            {
                FeedbackType.Boolean => "boolean",
                FeedbackType.Categorical => "categorical",
                FeedbackType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackType.Boolean,
                "categorical" => FeedbackType.Categorical,
                "numerical" => FeedbackType.Numerical,
                _ => null,
            };
        }
    }
}