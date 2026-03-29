//HintName: G.Models.InputVideoBackgroundSettingsLongBackgroundContentMatchMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Possible values - `trim` trims the background to the duration of the content - `speed_up` speeds up the background so that its duration matches the content duration<br/>
    /// Default Value: trim
    /// </summary>
    public enum InputVideoBackgroundSettingsLongBackgroundContentMatchMode
    {
        /// <summary>
        /// 
        /// </summary>
        ExtendContent,
        /// <summary>
        /// 
        /// </summary>
        SpeedUp,
        /// <summary>
        /// 
        /// </summary>
        Trim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputVideoBackgroundSettingsLongBackgroundContentMatchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputVideoBackgroundSettingsLongBackgroundContentMatchMode value)
        {
            return value switch
            {
                InputVideoBackgroundSettingsLongBackgroundContentMatchMode.ExtendContent => "extend_content",
                InputVideoBackgroundSettingsLongBackgroundContentMatchMode.SpeedUp => "speed_up",
                InputVideoBackgroundSettingsLongBackgroundContentMatchMode.Trim => "trim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputVideoBackgroundSettingsLongBackgroundContentMatchMode? ToEnum(string value)
        {
            return value switch
            {
                "extend_content" => InputVideoBackgroundSettingsLongBackgroundContentMatchMode.ExtendContent,
                "speed_up" => InputVideoBackgroundSettingsLongBackgroundContentMatchMode.SpeedUp,
                "trim" => InputVideoBackgroundSettingsLongBackgroundContentMatchMode.Trim,
                _ => null,
            };
        }
    }
}