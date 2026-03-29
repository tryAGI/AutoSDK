//HintName: G.Models.FeedbackDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackDiscriminatorType
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
    public static class FeedbackDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackDiscriminatorType value)
        {
            return value switch
            {
                FeedbackDiscriminatorType.Boolean => "boolean",
                FeedbackDiscriminatorType.Categorical => "categorical",
                FeedbackDiscriminatorType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackDiscriminatorType.Boolean,
                "categorical" => FeedbackDiscriminatorType.Categorical,
                "numerical" => FeedbackDiscriminatorType.Numerical,
                _ => null,
            };
        }
    }
}