//HintName: G.Models.InputVideoBackgroundSettingsShortBackgroundContentMatchMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Possible values: - `freeze` freezes the last frame of the background until the content is finished - `loop` loops the background until the content is finished - `slow_down` slows down the background so that its duration matches the content duration<br/>
    /// Default Value: freeze
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputVideoBackgroundSettingsShortBackgroundContentMatchMode
    {
        /// <summary>
        /// - `freeze` freezes the last frame of the background until the content is finished - `loop` loops the background until the content is finished - `slow_down` slows down the background so that its duration matches the content duration
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="freeze")]
        Freeze,
        /// <summary>
        /// - `freeze` freezes the last frame of the background until the content is finished - `loop` loops the background until the content is finished - `slow_down` slows down the background so that its duration matches the content duration
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="loop")]
        Loop,
        /// <summary>
        /// - `freeze` freezes the last frame of the background until the content is finished - `loop` loops the background until the content is finished - `slow_down` slows down the background so that its duration matches the content duration
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slow_down")]
        SlowDown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="slow_down_mci")]
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