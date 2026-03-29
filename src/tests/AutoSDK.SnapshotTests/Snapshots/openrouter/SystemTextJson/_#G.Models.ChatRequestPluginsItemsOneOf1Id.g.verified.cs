//HintName: G.Models.ChatRequestPluginsItemsOneOf1Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRequestPluginsItemsOneOf1Id
    {
        /// <summary>
        /// 
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPluginsItemsOneOf1IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginsItemsOneOf1Id value)
        {
            return value switch
            {
                ChatRequestPluginsItemsOneOf1Id.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginsItemsOneOf1Id? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => ChatRequestPluginsItemsOneOf1Id.Moderation,
                _ => null,
            };
        }
    }
}