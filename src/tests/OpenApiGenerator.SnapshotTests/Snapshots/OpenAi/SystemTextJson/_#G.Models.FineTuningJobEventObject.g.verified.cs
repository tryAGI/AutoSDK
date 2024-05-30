//HintName: G.Models.FineTuningJobEventObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuningJobEventObject
    {
        /// <summary>
        /// 
        /// </summary>
        FineTuningjobevent,
    }

    public static class FineTuningJobEventObjectExtensions
    {
        public static string ToValueString(this FineTuningJobEventObject value)
        {
            return value switch
            {
                FineTuningJobEventObject.FineTuningjobevent => "fine_tuning.job.event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningJobEventObject ToEnum(string value)
        {
            return value switch
            {
                "fine_tuning.job.event" => FineTuningJobEventObject.FineTuningjobevent,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningJobEventObject ToEnum(int value)
        {
            return value switch
            {
                0 => FineTuningJobEventObject.FineTuningjobevent,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}