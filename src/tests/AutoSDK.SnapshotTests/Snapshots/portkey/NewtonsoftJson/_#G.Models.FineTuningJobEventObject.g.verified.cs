//HintName: G.Models.FineTuningJobEventObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FineTuningJobEventObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fine_tuning.job.event")]
        FineTuningJobEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuningJobEventObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningJobEventObject value)
        {
            return value switch
            {
                FineTuningJobEventObject.FineTuningJobEvent => "fine_tuning.job.event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningJobEventObject? ToEnum(string value)
        {
            return value switch
            {
                "fine_tuning.job.event" => FineTuningJobEventObject.FineTuningJobEvent,
                _ => null,
            };
        }
    }
}