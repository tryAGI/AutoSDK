//HintName: G.Models.WhatsAppConversationInfoDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: unknown
    /// </summary>
    public enum WhatsAppConversationInfoDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        Outbound,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhatsAppConversationInfoDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhatsAppConversationInfoDirection value)
        {
            return value switch
            {
                WhatsAppConversationInfoDirection.Inbound => "inbound",
                WhatsAppConversationInfoDirection.Outbound => "outbound",
                WhatsAppConversationInfoDirection.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhatsAppConversationInfoDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => WhatsAppConversationInfoDirection.Inbound,
                "outbound" => WhatsAppConversationInfoDirection.Outbound,
                "unknown" => WhatsAppConversationInfoDirection.Unknown,
                _ => null,
            };
        }
    }
}