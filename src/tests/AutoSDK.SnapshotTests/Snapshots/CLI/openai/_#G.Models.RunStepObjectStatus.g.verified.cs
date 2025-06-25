﻿//HintName: G.Models.RunStepObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the run step, which can be either `in_progress`, `cancelled`, `failed`, `completed`, or `expired`.
    /// </summary>
    public enum RunStepObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunStepObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunStepObjectStatus value)
        {
            return value switch
            {
                RunStepObjectStatus.InProgress => "in_progress",
                RunStepObjectStatus.Cancelled => "cancelled",
                RunStepObjectStatus.Failed => "failed",
                RunStepObjectStatus.Completed => "completed",
                RunStepObjectStatus.Expired => "expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunStepObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => RunStepObjectStatus.InProgress,
                "cancelled" => RunStepObjectStatus.Cancelled,
                "failed" => RunStepObjectStatus.Failed,
                "completed" => RunStepObjectStatus.Completed,
                "expired" => RunStepObjectStatus.Expired,
                _ => null,
            };
        }
    }
}