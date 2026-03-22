//HintName: G.Models.GetConversationResponseModelStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConversationResponseModelStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in-progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="initiated")]
        Initiated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConversationResponseModelStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConversationResponseModelStatus value)
        {
            return value switch
            {
                GetConversationResponseModelStatus.Done => "done",
                GetConversationResponseModelStatus.Failed => "failed",
                GetConversationResponseModelStatus.InProgress => "in-progress",
                GetConversationResponseModelStatus.Initiated => "initiated",
                GetConversationResponseModelStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConversationResponseModelStatus? ToEnum(string value)
        {
            return value switch
            {
                "done" => GetConversationResponseModelStatus.Done,
                "failed" => GetConversationResponseModelStatus.Failed,
                "in-progress" => GetConversationResponseModelStatus.InProgress,
                "initiated" => GetConversationResponseModelStatus.Initiated,
                "processing" => GetConversationResponseModelStatus.Processing,
                _ => null,
            };
        }
    }
}