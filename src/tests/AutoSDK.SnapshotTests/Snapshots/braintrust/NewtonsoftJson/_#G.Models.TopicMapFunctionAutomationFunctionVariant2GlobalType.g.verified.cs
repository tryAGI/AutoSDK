//HintName: G.Models.TopicMapFunctionAutomationFunctionVariant2GlobalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TopicMapFunctionAutomationFunctionVariant2GlobalType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="global")]
        Global,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TopicMapFunctionAutomationFunctionVariant2GlobalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TopicMapFunctionAutomationFunctionVariant2GlobalType value)
        {
            return value switch
            {
                TopicMapFunctionAutomationFunctionVariant2GlobalType.Global => "global",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TopicMapFunctionAutomationFunctionVariant2GlobalType? ToEnum(string value)
        {
            return value switch
            {
                "global" => TopicMapFunctionAutomationFunctionVariant2GlobalType.Global,
                _ => null,
            };
        }
    }
}