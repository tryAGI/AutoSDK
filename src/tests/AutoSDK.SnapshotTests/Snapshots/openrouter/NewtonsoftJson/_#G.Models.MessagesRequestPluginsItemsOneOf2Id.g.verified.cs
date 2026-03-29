//HintName: G.Models.MessagesRequestPluginsItemsOneOf2Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestPluginsItemsOneOf2Id
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
    public static class MessagesRequestPluginsItemsOneOf2IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestPluginsItemsOneOf2Id value)
        {
            return value switch
            {
                MessagesRequestPluginsItemsOneOf2Id.Web => "web",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestPluginsItemsOneOf2Id? ToEnum(string value)
        {
            return value switch
            {
                "web" => MessagesRequestPluginsItemsOneOf2Id.Web,
                _ => null,
            };
        }
    }
}