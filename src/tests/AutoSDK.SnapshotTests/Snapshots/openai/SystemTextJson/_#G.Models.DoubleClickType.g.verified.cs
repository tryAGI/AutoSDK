//HintName: G.Models.DoubleClickType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the event type. For a double click action, this property is <br/>
    /// always set to `double_click`.<br/>
    /// Default Value: double_click
    /// </summary>
    public enum DoubleClickType
    {
        /// <summary>
        /// 
        /// </summary>
        DoubleClick,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DoubleClickTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DoubleClickType value)
        {
            return value switch
            {
                DoubleClickType.DoubleClick => "double_click",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DoubleClickType? ToEnum(string value)
        {
            return value switch
            {
                "double_click" => DoubleClickType.DoubleClick,
                _ => null,
            };
        }
    }
}