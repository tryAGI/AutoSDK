//HintName: G.Models.MessagesMessageParamContentOneOf1ItemsOneOf7Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessagesMessageParamContentOneOf1ItemsOneOf7Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="server_tool_use")]
        ServerToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesMessageParamContentOneOf1ItemsOneOf7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesMessageParamContentOneOf1ItemsOneOf7Type value)
        {
            return value switch
            {
                MessagesMessageParamContentOneOf1ItemsOneOf7Type.ServerToolUse => "server_tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf7Type? ToEnum(string value)
        {
            return value switch
            {
                "server_tool_use" => MessagesMessageParamContentOneOf1ItemsOneOf7Type.ServerToolUse,
                _ => null,
            };
        }
    }
}