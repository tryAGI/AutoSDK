//HintName: G.Models.ResponsesRequestPluginsItemsOneOf4Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponsesRequestPluginsItemsOneOf4Id
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response-healing")]
        ResponseHealing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsOneOf4IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsOneOf4Id value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsOneOf4Id.ResponseHealing => "response-healing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsOneOf4Id? ToEnum(string value)
        {
            return value switch
            {
                "response-healing" => ResponsesRequestPluginsItemsOneOf4Id.ResponseHealing,
                _ => null,
            };
        }
    }
}