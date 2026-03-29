//HintName: G.Models.StepFeedback2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StepFeedback2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="negative")]
        Negative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="positive")]
        Positive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepFeedback2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepFeedback2 value)
        {
            return value switch
            {
                StepFeedback2.Negative => "negative",
                StepFeedback2.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepFeedback2? ToEnum(string value)
        {
            return value switch
            {
                "negative" => StepFeedback2.Negative,
                "positive" => StepFeedback2.Positive,
                _ => null,
            };
        }
    }
}