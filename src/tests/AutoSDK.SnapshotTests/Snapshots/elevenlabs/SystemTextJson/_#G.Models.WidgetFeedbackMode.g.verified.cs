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
        During,
        /// <summary>
        /// 
        /// </summary>
        End,
        /// <summary>
        /// 
        /// </summary>
        None,
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
                WidgetFeedbackMode.During => "during",
                WidgetFeedbackMode.End => "end",
                WidgetFeedbackMode.None => "none",
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
                "during" => WidgetFeedbackMode.During,
                "end" => WidgetFeedbackMode.End,
                "none" => WidgetFeedbackMode.None,
                _ => null,
            };
        }
    }
}