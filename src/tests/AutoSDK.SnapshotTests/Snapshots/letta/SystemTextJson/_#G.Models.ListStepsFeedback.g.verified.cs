//HintName: G.Models.ListStepsFeedback.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListStepsFeedback
    {
        /// <summary>
        /// 
        /// </summary>
        Negative,
        /// <summary>
        /// 
        /// </summary>
        Positive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListStepsFeedbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListStepsFeedback value)
        {
            return value switch
            {
                ListStepsFeedback.Negative => "negative",
                ListStepsFeedback.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListStepsFeedback? ToEnum(string value)
        {
            return value switch
            {
                "negative" => ListStepsFeedback.Negative,
                "positive" => ListStepsFeedback.Positive,
                _ => null,
            };
        }
    }
}