//HintName: G.Models.ScrollType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the event type. For a scroll action, this property is <br/>
    /// always set to `scroll`.<br/>
    /// Default Value: scroll
    /// </summary>
    public enum ScrollType
    {
        /// <summary>
        /// 
        /// </summary>
        Scroll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrollTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrollType value)
        {
            return value switch
            {
                ScrollType.Scroll => "scroll",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrollType? ToEnum(string value)
        {
            return value switch
            {
                "scroll" => ScrollType.Scroll,
                _ => null,
            };
        }
    }
}