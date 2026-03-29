//HintName: G.Models.ListStepsFeedback2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListStepsFeedback2
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
    public static class ListStepsFeedback2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListStepsFeedback2 value)
        {
            return value switch
            {
                ListStepsFeedback2.Negative => "negative",
                ListStepsFeedback2.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListStepsFeedback2? ToEnum(string value)
        {
            return value switch
            {
                "negative" => ListStepsFeedback2.Negative,
                "positive" => ListStepsFeedback2.Positive,
                _ => null,
            };
        }
    }
}