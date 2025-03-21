//HintName: G.Models.ClickType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the event type. For a click action, this property is <br/>
    /// always set to `click`.<br/>
    /// Default Value: click
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClickType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="click")]
        Click,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClickTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClickType value)
        {
            return value switch
            {
                ClickType.Click => "click",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClickType? ToEnum(string value)
        {
            return value switch
            {
                "click" => ClickType.Click,
                _ => null,
            };
        }
    }
}