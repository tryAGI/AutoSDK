//HintName: G.Models.ReturnChatAudioReconstructionStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReturnChatAudioReconstructionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETED")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IN_PROGRESS")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUEUED")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReturnChatAudioReconstructionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReturnChatAudioReconstructionStatus value)
        {
            return value switch
            {
                ReturnChatAudioReconstructionStatus.Completed => "COMPLETED",
                ReturnChatAudioReconstructionStatus.Failed => "FAILED",
                ReturnChatAudioReconstructionStatus.InProgress => "IN_PROGRESS",
                ReturnChatAudioReconstructionStatus.Queued => "QUEUED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReturnChatAudioReconstructionStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ReturnChatAudioReconstructionStatus.Completed,
                "FAILED" => ReturnChatAudioReconstructionStatus.Failed,
                "IN_PROGRESS" => ReturnChatAudioReconstructionStatus.InProgress,
                "QUEUED" => ReturnChatAudioReconstructionStatus.Queued,
                _ => null,
            };
        }
    }
}