//HintName: G.Models.MessagesRequestPluginsItemsOneOf0Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestPluginsItemsOneOf0Id
    {
        /// <summary>
        /// 
        /// </summary>
        AutoRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestPluginsItemsOneOf0IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsOneOf0Id value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsOneOf0Id.AutoRouter => "auto-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsOneOf0Id? ToEnum(string value)
        {
            return value switch
            {
                "auto-router" => MessagesRequestPluginsItemsOneOf0Id.AutoRouter,
                _ => null,
            };
        }
    }
}