//HintName: G.Models.FeedbackPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackPublicType
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
    public static class FeedbackPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackPublicType value)
        {
            return value switch
            {
                FeedbackPublicType.Boolean => "boolean",
                FeedbackPublicType.Categorical => "categorical",
                FeedbackPublicType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackPublicType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackPublicType.Boolean,
                "categorical" => FeedbackPublicType.Categorical,
                "numerical" => FeedbackPublicType.Numerical,
                _ => null,
            };
        }
    }
}