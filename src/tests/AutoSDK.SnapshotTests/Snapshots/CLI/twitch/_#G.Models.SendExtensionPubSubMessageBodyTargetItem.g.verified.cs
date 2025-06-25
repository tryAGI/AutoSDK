//HintName: G.Models.SendExtensionPubSubMessageBodyTargetItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SendExtensionPubSubMessageBodyTargetItem
    {
        /// <summary>
        /// 
        /// </summary>
        Broadcast,
        /// <summary>
        /// 
        /// </summary>
        Global,
        /// <summary>
        /// 
        /// </summary>
        Whisper_userId_,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SendExtensionPubSubMessageBodyTargetItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SendExtensionPubSubMessageBodyTargetItem value)
        {
            return value switch
            {
                SendExtensionPubSubMessageBodyTargetItem.Broadcast => "broadcast",
                SendExtensionPubSubMessageBodyTargetItem.Global => "global",
                SendExtensionPubSubMessageBodyTargetItem.Whisper_userId_ => "whisper-<user-id>",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendExtensionPubSubMessageBodyTargetItem? ToEnum(string value)
        {
            return value switch
            {
                "broadcast" => SendExtensionPubSubMessageBodyTargetItem.Broadcast,
                "global" => SendExtensionPubSubMessageBodyTargetItem.Global,
                "whisper-<user-id>" => SendExtensionPubSubMessageBodyTargetItem.Whisper_userId_,
                _ => null,
            };
        }
    }
}