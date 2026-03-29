//HintName: G.Models.ResponsesRequestPluginsItemsOneOf0Id.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResponsesRequestPluginsItemsOneOf0Id
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto-router")]
        AutoRouter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponsesRequestPluginsItemsOneOf0IdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsesRequestPluginsItemsOneOf0Id value)
        {
            return value switch
            {
                ResponsesRequestPluginsItemsOneOf0Id.AutoRouter => "auto-router",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsesRequestPluginsItemsOneOf0Id? ToEnum(string value)
        {
            return value switch
            {
                "auto-router" => ResponsesRequestPluginsItemsOneOf0Id.AutoRouter,
                _ => null,
            };
        }
    }
}