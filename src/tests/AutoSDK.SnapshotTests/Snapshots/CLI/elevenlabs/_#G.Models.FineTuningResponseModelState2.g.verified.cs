﻿//HintName: G.Models.FineTuningResponseModelState2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuningResponseModelState2
    {
        /// <summary>
        /// 
        /// </summary>
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        FineTuning,
        /// <summary>
        /// 
        /// </summary>
        FineTuned,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Delayed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuningResponseModelState2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningResponseModelState2 value)
        {
            return value switch
            {
                FineTuningResponseModelState2.NotStarted => "not_started",
                FineTuningResponseModelState2.Queued => "queued",
                FineTuningResponseModelState2.FineTuning => "fine_tuning",
                FineTuningResponseModelState2.FineTuned => "fine_tuned",
                FineTuningResponseModelState2.Failed => "failed",
                FineTuningResponseModelState2.Delayed => "delayed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningResponseModelState2? ToEnum(string value)
        {
            return value switch
            {
                "not_started" => FineTuningResponseModelState2.NotStarted,
                "queued" => FineTuningResponseModelState2.Queued,
                "fine_tuning" => FineTuningResponseModelState2.FineTuning,
                "fine_tuned" => FineTuningResponseModelState2.FineTuned,
                "failed" => FineTuningResponseModelState2.Failed,
                "delayed" => FineTuningResponseModelState2.Delayed,
                _ => null,
            };
        }
    }
}