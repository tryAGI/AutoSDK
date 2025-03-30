//HintName: G.Models.WidgetExpandable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WidgetExpandable
    {
        /// <summary>
        /// 
        /// </summary>
        Never,
        /// <summary>
        /// 
        /// </summary>
        Mobile,
        /// <summary>
        /// 
        /// </summary>
        Desktop,
        /// <summary>
        /// 
        /// </summary>
        Always,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WidgetExpandableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WidgetExpandable value)
        {
            return value switch
            {
                WidgetExpandable.Never => "never",
                WidgetExpandable.Mobile => "mobile",
                WidgetExpandable.Desktop => "desktop",
                WidgetExpandable.Always => "always",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WidgetExpandable? ToEnum(string value)
        {
            return value switch
            {
                "never" => WidgetExpandable.Never,
                "mobile" => WidgetExpandable.Mobile,
                "desktop" => WidgetExpandable.Desktop,
                "always" => WidgetExpandable.Always,
                _ => null,
            };
        }
    }
}