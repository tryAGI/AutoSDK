//HintName: G.Models.FeedbackObjectPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackObjectPublicType
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
    public static class FeedbackObjectPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackObjectPublicType value)
        {
            return value switch
            {
                FeedbackObjectPublicType.Boolean => "boolean",
                FeedbackObjectPublicType.Categorical => "categorical",
                FeedbackObjectPublicType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackObjectPublicType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackObjectPublicType.Boolean,
                "categorical" => FeedbackObjectPublicType.Categorical,
                "numerical" => FeedbackObjectPublicType.Numerical,
                _ => null,
            };
        }
    }
}