//HintName: G.Models.MessagesRequestPluginsItemsOneOf4Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestPluginsItemsOneOf4Id
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseHealing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestPluginsItemsOneOf4IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsOneOf4Id value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsOneOf4Id.ResponseHealing => "response-healing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsOneOf4Id? ToEnum(string value)
        {
            return value switch
            {
                "response-healing" => MessagesRequestPluginsItemsOneOf4Id.ResponseHealing,
                _ => null,
            };
        }
    }
}