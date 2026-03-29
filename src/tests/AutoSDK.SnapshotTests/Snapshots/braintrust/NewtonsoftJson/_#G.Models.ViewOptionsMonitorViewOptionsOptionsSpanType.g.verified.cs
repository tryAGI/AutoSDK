//HintName: G.Models.ViewOptionsMonitorViewOptionsOptionsSpanType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ViewOptionsMonitorViewOptionsOptionsSpanType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="frame")]
        Frame,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="range")]
        Range,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewOptionsMonitorViewOptionsOptionsSpanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewOptionsMonitorViewOptionsOptionsSpanType value)
        {
            return value switch
            {
                ViewOptionsMonitorViewOptionsOptionsSpanType.Frame => "frame",
                ViewOptionsMonitorViewOptionsOptionsSpanType.Range => "range",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewOptionsMonitorViewOptionsOptionsSpanType? ToEnum(string value)
        {
            return value switch
            {
                "frame" => ViewOptionsMonitorViewOptionsOptionsSpanType.Frame,
                "range" => ViewOptionsMonitorViewOptionsOptionsSpanType.Range,
                _ => null,
            };
        }
    }
}