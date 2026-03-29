//HintName: G.Models.FeedbackCreateDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedbackCreateDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="boolean")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="categorical")]
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="numerical")]
        Numerical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FeedbackCreateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackCreateDiscriminatorType value)
        {
            return value switch
            {
                FeedbackCreateDiscriminatorType.Boolean => "boolean",
                FeedbackCreateDiscriminatorType.Categorical => "categorical",
                FeedbackCreateDiscriminatorType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackCreateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackCreateDiscriminatorType.Boolean,
                "categorical" => FeedbackCreateDiscriminatorType.Categorical,
                "numerical" => FeedbackCreateDiscriminatorType.Numerical,
                _ => null,
            };
        }
    }
}