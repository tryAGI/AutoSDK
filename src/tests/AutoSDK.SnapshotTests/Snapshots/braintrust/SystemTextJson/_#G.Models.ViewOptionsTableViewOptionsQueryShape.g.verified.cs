//HintName: G.Models.ViewOptionsTableViewOptionsQueryShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ViewOptionsTableViewOptionsQueryShape
    {
        /// <summary>
        /// 
        /// </summary>
        Spans,
        /// <summary>
        /// 
        /// </summary>
        Traces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewOptionsTableViewOptionsQueryShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewOptionsTableViewOptionsQueryShape value)
        {
            return value switch
            {
                ViewOptionsTableViewOptionsQueryShape.Spans => "spans",
                ViewOptionsTableViewOptionsQueryShape.Traces => "traces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewOptionsTableViewOptionsQueryShape? ToEnum(string value)
        {
            return value switch
            {
                "spans" => ViewOptionsTableViewOptionsQueryShape.Spans,
                "traces" => ViewOptionsTableViewOptionsQueryShape.Traces,
                _ => null,
            };
        }
    }
}