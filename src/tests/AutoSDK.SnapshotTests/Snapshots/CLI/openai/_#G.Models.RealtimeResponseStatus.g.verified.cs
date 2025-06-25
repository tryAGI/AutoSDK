﻿//HintName: G.Models.RealtimeResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The final status of the response (`completed`, `cancelled`, `failed`, or <br/>
    /// `incomplete`).
    /// </summary>
    public enum RealtimeResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
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
        Incomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseStatus value)
        {
            return value switch
            {
                RealtimeResponseStatus.Completed => "completed",
                RealtimeResponseStatus.Cancelled => "cancelled",
                RealtimeResponseStatus.Failed => "failed",
                RealtimeResponseStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeResponseStatus.Completed,
                "cancelled" => RealtimeResponseStatus.Cancelled,
                "failed" => RealtimeResponseStatus.Failed,
                "incomplete" => RealtimeResponseStatus.Incomplete,
                _ => null,
            };
        }
    }
}