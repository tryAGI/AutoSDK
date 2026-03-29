//HintName: G.Models.ReviewSettingsSamplingEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `task_id` - By Task ID<br/>
    /// * `random` - Random
    /// </summary>
    public enum ReviewSettingsSamplingEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Random,
        /// <summary>
        /// 
        /// </summary>
        TaskId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSettingsSamplingEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSettingsSamplingEnum value)
        {
            return value switch
            {
                ReviewSettingsSamplingEnum.Random => "random",
                ReviewSettingsSamplingEnum.TaskId => "task_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSettingsSamplingEnum? ToEnum(string value)
        {
            return value switch
            {
                "random" => ReviewSettingsSamplingEnum.Random,
                "task_id" => ReviewSettingsSamplingEnum.TaskId,
                _ => null,
            };
        }
    }
}