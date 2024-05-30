//HintName: G.Models.FineTuningJobCheckpointObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "fine_tuning.job.checkpoint".
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuningJobCheckpointObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fine_tuning.job.checkpoint")]
        FineTuningjobcheckpoint,
    }

    public static class FineTuningJobCheckpointObjectExtensions
    {
        public static string ToValueString(this FineTuningJobCheckpointObject value)
        {
            return value switch
            {
                FineTuningJobCheckpointObject.FineTuningjobcheckpoint => "fine_tuning.job.checkpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningJobCheckpointObject ToEnum(string value)
        {
            return value switch
            {
                "fine_tuning.job.checkpoint" => FineTuningJobCheckpointObject.FineTuningjobcheckpoint,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningJobCheckpointObject ToEnum(int value)
        {
            return value switch
            {
                0 => FineTuningJobCheckpointObject.FineTuningjobcheckpoint,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}