//HintName: G.Models.FineTuneStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of a fine-tune
    /// </summary>
    public enum FineTuneStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Training,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneStatus value)
        {
            return value switch
            {
                FineTuneStatus.Completed => "completed",
                FineTuneStatus.Created => "created",
                FineTuneStatus.Failed => "failed",
                FineTuneStatus.Training => "training",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => FineTuneStatus.Completed,
                "created" => FineTuneStatus.Created,
                "failed" => FineTuneStatus.Failed,
                "training" => FineTuneStatus.Training,
                _ => null,
            };
        }
    }
}