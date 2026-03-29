//HintName: G.Models.ChatRequestPluginsItemsOneOf5Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatRequestPluginsItemsOneOf5Id
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="context-compression")]
        ContextCompression,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPluginsItemsOneOf5IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginsItemsOneOf5Id value)
        {
            return value switch
            {
                ChatRequestPluginsItemsOneOf5Id.ContextCompression => "context-compression",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginsItemsOneOf5Id? ToEnum(string value)
        {
            return value switch
            {
                "context-compression" => ChatRequestPluginsItemsOneOf5Id.ContextCompression,
                _ => null,
            };
        }
    }
}