//HintName: G.Models.ChatRequestPluginsItemsOneOf0Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRequestPluginsItemsOneOf0Id
    {
        /// <summary>
        /// 
        /// </summary>
        AutoRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestPluginsItemsOneOf0IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestPluginsItemsOneOf0Id value)
        {
            return value switch
            {
                ChatRequestPluginsItemsOneOf0Id.AutoRouter => "auto-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestPluginsItemsOneOf0Id? ToEnum(string value)
        {
            return value switch
            {
                "auto-router" => ChatRequestPluginsItemsOneOf0Id.AutoRouter,
                _ => null,
            };
        }
    }
}