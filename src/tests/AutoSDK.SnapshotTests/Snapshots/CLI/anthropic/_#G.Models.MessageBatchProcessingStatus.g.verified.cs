﻿//HintName: G.Models.MessageBatchProcessingStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Processing status of the Message Batch.
    /// </summary>
    public enum MessageBatchProcessingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Canceling,
        /// <summary>
        /// 
        /// </summary>
        Ended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageBatchProcessingStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageBatchProcessingStatus value)
        {
            return value switch
            {
                MessageBatchProcessingStatus.InProgress => "in_progress",
                MessageBatchProcessingStatus.Canceling => "canceling",
                MessageBatchProcessingStatus.Ended => "ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageBatchProcessingStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => MessageBatchProcessingStatus.InProgress,
                "canceling" => MessageBatchProcessingStatus.Canceling,
                "ended" => MessageBatchProcessingStatus.Ended,
                _ => null,
            };
        }
    }
}