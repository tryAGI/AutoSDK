//HintName: G.Models.BaseMessagesResultContentItemsOneOf5CallerOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BaseMessagesResultContentItemsOneOf5CallerOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="direct")]
        Direct,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BaseMessagesResultContentItemsOneOf5CallerOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BaseMessagesResultContentItemsOneOf5CallerOneOf0Type value)
        {
            return value switch
            {
                BaseMessagesResultContentItemsOneOf5CallerOneOf0Type.Direct => "direct",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BaseMessagesResultContentItemsOneOf5CallerOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BaseMessagesResultContentItemsOneOf5CallerOneOf0Type.Direct,
                _ => null,
            };
        }
    }
}