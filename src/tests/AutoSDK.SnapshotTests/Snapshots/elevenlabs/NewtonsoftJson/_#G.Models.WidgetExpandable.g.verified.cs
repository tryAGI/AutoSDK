//HintName: G.Models.WidgetExpandable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WidgetExpandable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="always")]
        Always,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desktop")]
        Desktop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mobile")]
        Mobile,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="never")]
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