//HintName: G.Models.FeedbackObjectPublicDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackObjectPublicDiscriminatorType
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
    public static class FeedbackObjectPublicDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackObjectPublicDiscriminatorType value)
        {
            return value switch
            {
                FeedbackObjectPublicDiscriminatorType.Boolean => "boolean",
                FeedbackObjectPublicDiscriminatorType.Categorical => "categorical",
                FeedbackObjectPublicDiscriminatorType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackObjectPublicDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackObjectPublicDiscriminatorType.Boolean,
                "categorical" => FeedbackObjectPublicDiscriminatorType.Categorical,
                "numerical" => FeedbackObjectPublicDiscriminatorType.Numerical,
                _ => null,
            };
        }
    }
}