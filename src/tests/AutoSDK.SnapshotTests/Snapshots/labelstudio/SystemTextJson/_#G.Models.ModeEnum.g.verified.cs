//HintName: G.Models.ModeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `settings` - Only settings<br/>
    /// * `settings,data` - Settings and tasks
    /// </summary>
    public enum ModeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Settings,
        /// <summary>
        /// 
        /// </summary>
        Settings_data,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModeEnum value)
        {
            return value switch
            {
                ModeEnum.Settings => "settings",
                ModeEnum.Settings_data => "settings,data",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "settings" => ModeEnum.Settings,
                "settings,data" => ModeEnum.Settings_data,
                _ => null,
            };
        }
    }
}