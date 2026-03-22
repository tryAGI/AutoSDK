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
        Always,
        /// <summary>
        /// 
        /// </summary>
        Desktop,
        /// <summary>
        /// 
        /// </summary>
        Mobile,
        /// <summary>
        /// 
        /// </summary>
        Never,
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
                WidgetExpandable.Always => "always",
                WidgetExpandable.Desktop => "desktop",
                WidgetExpandable.Mobile => "mobile",
                WidgetExpandable.Never => "never",
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
                "always" => WidgetExpandable.Always,
                "desktop" => WidgetExpandable.Desktop,
                "mobile" => WidgetExpandable.Mobile,
                "never" => WidgetExpandable.Never,
                _ => null,
            };
        }
    }
}