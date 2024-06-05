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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SendExtensionPubSubMessageBodyTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendExtensionPubSubMessageBodyTarget? ToEnum(string value)
        {
            return value switch
            {
                "broadcast" => SendExtensionPubSubMessageBodyTarget.Broadcast,
                "global" => SendExtensionPubSubMessageBodyTarget.Global,
                "whisper-<user-id>" => SendExtensionPubSubMessageBodyTarget.Whisper_userId_,
                _ => null,
            };
        }
    }
}