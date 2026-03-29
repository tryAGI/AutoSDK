//HintName: G.Models.MessagesRequestThinkingOneOf0Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesRequestThinkingOneOf0Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestThinkingOneOf0TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestThinkingOneOf0Type value)
        {
            return value switch
            {
                MessagesRequestThinkingOneOf0Type.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestThinkingOneOf0Type? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => MessagesRequestThinkingOneOf0Type.Enabled,
                _ => null,
            };
        }
    }
}