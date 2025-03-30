//HintName: G.Models.WidgetFeedbackMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WidgetFeedbackMode
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        During,
        /// <summary>
        /// 
        /// </summary>
        End,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WidgetFeedbackModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetFeedbackMode value)
        {
            return value switch
            {
                WidgetFeedbackMode.None => "none",
                WidgetFeedbackMode.During => "during",
                WidgetFeedbackMode.End => "end",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetFeedbackMode? ToEnum(string value)
        {
            return value switch
            {
                "none" => WidgetFeedbackMode.None,
                "during" => WidgetFeedbackMode.During,
                "end" => WidgetFeedbackMode.End,
                _ => null,
            };
        }
    }
}