//HintName: G.Models.SendExtensionPubSubMessageBodyTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SendExtensionPubSubMessageBodyTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="broadcast")]
        Broadcast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="global")]
        Global,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whisper-<user-id>")]
        Whisper_userId_,
    }

    public static class SendExtensionPubSubMessageBodyTargetExtensions
    {
        public static string ToValueString(this SendExtensionPubSubMessageBodyTarget value)
        {
            return value switch
            {
                SendExtensionPubSubMessageBodyTarget.Broadcast => "broadcast",
                SendExtensionPubSubMessageBodyTarget.Global => "global",
                SendExtensionPubSubMessageBodyTarget.Whisper_userId_ => "whisper-<user-id>",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SendExtensionPubSubMessageBodyTarget ToEnum(string value)
        {
            return value switch
            {
                "broadcast" => SendExtensionPubSubMessageBodyTarget.Broadcast,
                "global" => SendExtensionPubSubMessageBodyTarget.Global,
                "whisper-<user-id>" => SendExtensionPubSubMessageBodyTarget.Whisper_userId_,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SendExtensionPubSubMessageBodyTarget ToEnum(int value)
        {
            return value switch
            {
                0 => SendExtensionPubSubMessageBodyTarget.Broadcast,
                1 => SendExtensionPubSubMessageBodyTarget.Global,
                2 => SendExtensionPubSubMessageBodyTarget.Whisper_userId_,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}