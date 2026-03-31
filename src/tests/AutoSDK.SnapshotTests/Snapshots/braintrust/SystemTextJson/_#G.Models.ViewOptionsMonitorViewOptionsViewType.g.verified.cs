//HintName: G.Models.ViewOptionsMonitorViewOptionsViewType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ViewOptionsMonitorViewOptionsViewType
    {
        /// <summary>
        /// 
        /// </summary>
        Monitor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewOptionsMonitorViewOptionsViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewOptionsMonitorViewOptionsViewType value)
        {
            return value switch
            {
                ViewOptionsMonitorViewOptionsViewType.Monitor => "monitor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewOptionsMonitorViewOptionsViewType? ToEnum(string value)
        {
            return value switch
            {
                "monitor" => ViewOptionsMonitorViewOptionsViewType.Monitor,
                _ => null,
            };
        }
    }
}