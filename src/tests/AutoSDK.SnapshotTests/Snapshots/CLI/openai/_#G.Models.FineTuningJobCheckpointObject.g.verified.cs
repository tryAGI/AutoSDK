//HintName: G.Models.FineTuningJobCheckpointObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "fine_tuning.job.checkpoint".
    /// </summary>
    public enum FineTuningJobCheckpointObject
    {
        /// <summary>
        /// 
        /// </summary>
        FineTuningJobCheckpoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuningJobCheckpointObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningJobCheckpointObject value)
        {
            return value switch
            {
                FineTuningJobCheckpointObject.FineTuningJobCheckpoint => "fine_tuning.job.checkpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningJobCheckpointObject? ToEnum(string value)
        {
            return value switch
            {
                "fine_tuning.job.checkpoint" => FineTuningJobCheckpointObject.FineTuningJobCheckpoint,
                _ => null,
            };
        }
    }
}