//HintName: G.Models.PreRecordedControllerGetPreRecordedJobsV2Statu.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PreRecordedControllerGetPreRecordedJobsV2Statu
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
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