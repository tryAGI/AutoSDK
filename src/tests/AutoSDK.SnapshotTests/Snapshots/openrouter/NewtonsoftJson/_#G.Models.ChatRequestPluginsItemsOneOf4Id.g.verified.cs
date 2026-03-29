//HintName: G.Models.ChatRequestPluginsItemsOneOf4Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatRequestPluginsItemsOneOf4Id
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response-healing")]
        ResponseHealing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPluginsItemsOneOf4IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginsItemsOneOf4Id value)
        {
            return value switch
            {
                ChatRequestPluginsItemsOneOf4Id.ResponseHealing => "response-healing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginsItemsOneOf4Id? ToEnum(string value)
        {
            return value switch
            {
                "response-healing" => ChatRequestPluginsItemsOneOf4Id.ResponseHealing,
                _ => null,
            };
        }
    }
}