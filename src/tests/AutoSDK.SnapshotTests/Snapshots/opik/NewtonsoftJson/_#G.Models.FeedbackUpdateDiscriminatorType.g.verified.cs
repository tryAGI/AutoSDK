//HintName: G.Models.FeedbackUpdateDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedbackUpdateDiscriminatorType
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
    public static class FeedbackUpdateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FeedbackUpdateDiscriminatorType value)
        {
            return value switch
            {
                FeedbackUpdateDiscriminatorType.Boolean => "boolean",
                FeedbackUpdateDiscriminatorType.Categorical => "categorical",
                FeedbackUpdateDiscriminatorType.Numerical => "numerical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FeedbackUpdateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "boolean" => FeedbackUpdateDiscriminatorType.Boolean,
                "categorical" => FeedbackUpdateDiscriminatorType.Categorical,
                "numerical" => FeedbackUpdateDiscriminatorType.Numerical,
                _ => null,
            };
        }
    }
}