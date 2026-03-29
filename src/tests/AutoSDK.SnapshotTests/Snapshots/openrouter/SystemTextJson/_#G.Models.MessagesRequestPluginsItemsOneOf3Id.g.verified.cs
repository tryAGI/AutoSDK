//HintName: G.Models.MessagesRequestPluginsItemsOneOf3Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestPluginsItemsOneOf3Id
    {
        /// <summary>
        /// 
        /// </summary>
        FileParser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestPluginsItemsOneOf3IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsOneOf3Id value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsOneOf3Id.FileParser => "file-parser",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsOneOf3Id? ToEnum(string value)
        {
            return value switch
            {
                "file-parser" => MessagesRequestPluginsItemsOneOf3Id.FileParser,
                _ => null,
            };
        }
    }
}