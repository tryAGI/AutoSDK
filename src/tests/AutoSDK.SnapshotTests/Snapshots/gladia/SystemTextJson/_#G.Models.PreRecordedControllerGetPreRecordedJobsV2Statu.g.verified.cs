//HintName: G.Models.PreRecordedControllerGetPreRecordedJobsV2Statu.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreRecordedControllerGetPreRecordedJobsV2Statu
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreRecordedControllerGetPreRecordedJobsV2StatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreRecordedControllerGetPreRecordedJobsV2Statu value)
        {
            return value switch
            {
                PreRecordedControllerGetPreRecordedJobsV2Statu.Done => "done",
                PreRecordedControllerGetPreRecordedJobsV2Statu.Error => "error",
                PreRecordedControllerGetPreRecordedJobsV2Statu.Processing => "processing",
                PreRecordedControllerGetPreRecordedJobsV2Statu.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreRecordedControllerGetPreRecordedJobsV2Statu? ToEnum(string value)
        {
            return value switch
            {
                "done" => PreRecordedControllerGetPreRecordedJobsV2Statu.Done,
                "error" => PreRecordedControllerGetPreRecordedJobsV2Statu.Error,
                "processing" => PreRecordedControllerGetPreRecordedJobsV2Statu.Processing,
                "queued" => PreRecordedControllerGetPreRecordedJobsV2Statu.Queued,
                _ => null,
            };
        }
    }
}