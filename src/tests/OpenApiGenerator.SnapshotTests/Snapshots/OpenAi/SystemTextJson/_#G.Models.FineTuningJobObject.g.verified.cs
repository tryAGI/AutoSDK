//HintName: G.Models.FineTuningJobObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "fine_tuning.job".
    /// </summary>
    public enum FineTuningJobObject
    {
        /// <summary>
        /// 
        /// </summary>
        FineTuningjob,
    }

    public static class FineTuningJobObjectExtensions
    {
        public static string ToValueString(this FineTuningJobObject value)
        {
            return value switch
            {
                FineTuningJobObject.FineTuningjob => "fine_tuning.job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningJobObject ToEnum(string value)
        {
            return value switch
            {
                "fine_tuning.job" => FineTuningJobObject.FineTuningjob,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static FineTuningJobObject ToEnum(int value)
        {
            return value switch
            {
                0 => FineTuningJobObject.FineTuningjob,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}