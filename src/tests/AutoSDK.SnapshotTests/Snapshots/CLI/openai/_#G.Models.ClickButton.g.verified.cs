//HintName: G.Models.ClickButton.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates which mouse button was pressed during the click. One of `left`, `right`, `wheel`, `back`, or `forward`.
    /// </summary>
    public enum ClickButton
    {
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
        /// <summary>
        /// 
        /// </summary>
        Wheel,
        /// <summary>
        /// 
        /// </summary>
        Back,
        /// <summary>
        /// 
        /// </summary>
        Forward,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClickButtonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClickButton value)
        {
            return value switch
            {
                ClickButton.Left => "left",
                ClickButton.Right => "right",
                ClickButton.Wheel => "wheel",
                ClickButton.Back => "back",
                ClickButton.Forward => "forward",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClickButton? ToEnum(string value)
        {
            return value switch
            {
                "left" => ClickButton.Left,
                "right" => ClickButton.Right,
                "wheel" => ClickButton.Wheel,
                "back" => ClickButton.Back,
                "forward" => ClickButton.Forward,
                _ => null,
            };
        }
    }
}