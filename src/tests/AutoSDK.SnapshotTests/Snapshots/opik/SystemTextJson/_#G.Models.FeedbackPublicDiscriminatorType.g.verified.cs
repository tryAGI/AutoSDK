//HintName: G.Models.FeedbackPublicDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackPublicDiscriminatorType
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
    public static class FeedbackPublicDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackPublicDiscriminatorType value)
        {
            return value switch
            {
                FeedbackPublicDiscriminatorType.Boolean => "boolean",
                FeedbackPublicDiscriminatorType.Categorical => "categorical",
                FeedbackPublicDiscriminatorType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackPublicDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackPublicDiscriminatorType.Boolean,
                "categorical" => FeedbackPublicDiscriminatorType.Categorical,
                "numerical" => FeedbackPublicDiscriminatorType.Numerical,
                _ => null,
            };
        }
    }
}