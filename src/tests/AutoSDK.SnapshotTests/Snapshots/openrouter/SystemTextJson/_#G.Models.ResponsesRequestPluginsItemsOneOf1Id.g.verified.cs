//HintName: G.Models.ResponsesRequestPluginsItemsOneOf1Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsesRequestPluginsItemsOneOf1Id
    {
        /// <summary>
        /// 
        /// </summary>
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsOneOf1IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsOneOf1Id value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsOneOf1Id.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsOneOf1Id? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => ResponsesRequestPluginsItemsOneOf1Id.Moderation,
                _ => null,
            };
        }
    }
}