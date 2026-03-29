//HintName: G.Models.InputVideoBackgroundSettingsShortBackgroundContentMatchMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Possible values: - `freeze` freezes the last frame of the background until the content is finished - `loop` loops the background until the content is finished - `slow_down` slows down the background so that its duration matches the content duration<br/>
    /// Default Value: freeze
    /// </summary>
    public enum InputVideoBackgroundSettingsShortBackgroundContentMatchMode
    {
        /// <summary>
        /// - `freeze` freezes the last frame of the background until the content is finished - `loop` loops the background until the content is finished - `slow_down` slows down the background so that its duration matches the content duration
        /// </summary>
        Freeze,
        /// <summary>
        /// - `freeze` freezes the last frame of the background until the content is finished - `loop` loops the background until the content is finished - `slow_down` slows down the background so that its duration matches the content duration
        /// </summary>
        Loop,
        /// <summary>
        /// - `freeze` freezes the last frame of the background until the content is finished - `loop` loops the background until the content is finished - `slow_down` slows down the background so that its duration matches the content duration
        /// </summary>
        SlowDown,
        /// <summary>
        /// 
        /// </summary>
        SlowDownMci,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputVideoBackgroundSettingsShortBackgroundContentMatchModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputVideoBackgroundSettingsShortBackgroundContentMatchMode value)
        {
            return value switch
            {
                InputVideoBackgroundSettingsShortBackgroundContentMatchMode.Freeze => "freeze",
                InputVideoBackgroundSettingsShortBackgroundContentMatchMode.Loop => "loop",
                InputVideoBackgroundSettingsShortBackgroundContentMatchMode.SlowDown => "slow_down",
                InputVideoBackgroundSettingsShortBackgroundContentMatchMode.SlowDownMci => "slow_down_mci",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputVideoBackgroundSettingsShortBackgroundContentMatchMode? ToEnum(string value)
        {
            return value switch
            {
                "freeze" => InputVideoBackgroundSettingsShortBackgroundContentMatchMode.Freeze,
                "loop" => InputVideoBackgroundSettingsShortBackgroundContentMatchMode.Loop,
                "slow_down" => InputVideoBackgroundSettingsShortBackgroundContentMatchMode.SlowDown,
                "slow_down_mci" => InputVideoBackgroundSettingsShortBackgroundContentMatchMode.SlowDownMci,
                _ => null,
            };
        }
    }
}