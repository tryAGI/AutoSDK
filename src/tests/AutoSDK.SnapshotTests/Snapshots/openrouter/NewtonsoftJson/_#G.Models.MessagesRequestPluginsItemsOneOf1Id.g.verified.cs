//HintName: G.Models.MessagesRequestPluginsItemsOneOf1Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestPluginsItemsOneOf1Id
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="moderation")]
        Moderation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestPluginsItemsOneOf1IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsOneOf1Id value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsOneOf1Id.Moderation => "moderation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsOneOf1Id? ToEnum(string value)
        {
            return value switch
            {
                "moderation" => MessagesRequestPluginsItemsOneOf1Id.Moderation,
                _ => null,
            };
        }
    }
}