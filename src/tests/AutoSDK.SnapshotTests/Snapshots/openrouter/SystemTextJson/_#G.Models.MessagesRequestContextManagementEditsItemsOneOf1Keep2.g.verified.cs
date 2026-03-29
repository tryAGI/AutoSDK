//HintName: G.Models.MessagesRequestContextManagementEditsItemsOneOf1Keep2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestContextManagementEditsItemsOneOf1Keep2
    {
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestContextManagementEditsItemsOneOf1Keep2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestContextManagementEditsItemsOneOf1Keep2 value)
        {
            return value switch
            {
                MessagesRequestContextManagementEditsItemsOneOf1Keep2.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestContextManagementEditsItemsOneOf1Keep2? ToEnum(string value)
        {
            return value switch
            {
                "all" => MessagesRequestContextManagementEditsItemsOneOf1Keep2.All,
                _ => null,
            };
        }
    }
}