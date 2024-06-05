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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuningJobObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningJobObject value)
        {
            return value switch
            {
                FineTuningJobObject.FineTuningjob => "fine_tuning.job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningJobObject? ToEnum(string value)
        {
            return value switch
            {
                "fine_tuning.job" => FineTuningJobObject.FineTuningjob,
                _ => null,
            };
        }
    }
}