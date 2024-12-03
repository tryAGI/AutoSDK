//HintName: G.Models.FeedbackType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for feedback types.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="continuous")]
        Continuous,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="categorical")]
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="freeform")]
        Freeform,
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
                FeedbackType.Continuous => "continuous",
                FeedbackType.Categorical => "categorical",
                FeedbackType.Freeform => "freeform",
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
                "continuous" => FeedbackType.Continuous,
                "categorical" => FeedbackType.Categorical,
                "freeform" => FeedbackType.Freeform,
                _ => null,
            };
        }
    }
}