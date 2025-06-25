﻿//HintName: G.Models.RealtimeResponseStatusDetailsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of error that caused the response to fail, corresponding <br/>
    /// with the `status` field (`completed`, `cancelled`, `incomplete`, <br/>
    /// `failed`).
    /// </summary>
    public enum RealtimeResponseStatusDetailsType
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
    public static class RealtimeResponseStatusDetailsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseStatusDetailsType value)
        {
            return value switch
            {
                RealtimeResponseStatusDetailsType.Completed => "completed",
                RealtimeResponseStatusDetailsType.Cancelled => "cancelled",
                RealtimeResponseStatusDetailsType.Failed => "failed",
                RealtimeResponseStatusDetailsType.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseStatusDetailsType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeResponseStatusDetailsType.Completed,
                "cancelled" => RealtimeResponseStatusDetailsType.Cancelled,
                "failed" => RealtimeResponseStatusDetailsType.Failed,
                "incomplete" => RealtimeResponseStatusDetailsType.Incomplete,
                _ => null,
            };
        }
    }
}