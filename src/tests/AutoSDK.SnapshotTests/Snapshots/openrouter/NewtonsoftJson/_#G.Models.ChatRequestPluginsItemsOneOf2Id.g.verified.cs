//HintName: G.Models.ChatRequestPluginsItemsOneOf2Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatRequestPluginsItemsOneOf2Id
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web")]
        Web,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPluginsItemsOneOf2IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginsItemsOneOf2Id value)
        {
            return value switch
            {
                ChatRequestPluginsItemsOneOf2Id.Web => "web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginsItemsOneOf2Id? ToEnum(string value)
        {
            return value switch
            {
                "web" => ChatRequestPluginsItemsOneOf2Id.Web,
                _ => null,
            };
        }
    }
}