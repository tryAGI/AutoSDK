//HintName: G.Models.MessagesRequestToolsItemsOneOf3UserLocationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestToolsItemsOneOf3UserLocationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="approximate")]
        Approximate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolsItemsOneOf3UserLocationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolsItemsOneOf3UserLocationType value)
        {
            return value switch
            {
                MessagesRequestToolsItemsOneOf3UserLocationType.Approximate => "approximate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolsItemsOneOf3UserLocationType? ToEnum(string value)
        {
            return value switch
            {
                "approximate" => MessagesRequestToolsItemsOneOf3UserLocationType.Approximate,
                _ => null,
            };
        }
    }
}