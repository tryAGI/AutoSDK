//HintName: G.Models.PropertiesSuggestReplyInfoReplyMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 回复模式
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesSuggestReplyInfoReplyMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customized")]
        Customized,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disable")]
        Disable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enable")]
        Enable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesSuggestReplyInfoReplyModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesSuggestReplyInfoReplyMode value)
        {
            return value switch
            {
                PropertiesSuggestReplyInfoReplyMode.Customized => "customized",
                PropertiesSuggestReplyInfoReplyMode.Disable => "disable",
                PropertiesSuggestReplyInfoReplyMode.Enable => "enable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesSuggestReplyInfoReplyMode? ToEnum(string value)
        {
            return value switch
            {
                "customized" => PropertiesSuggestReplyInfoReplyMode.Customized,
                "disable" => PropertiesSuggestReplyInfoReplyMode.Disable,
                "enable" => PropertiesSuggestReplyInfoReplyMode.Enable,
                _ => null,
            };
        }
    }
}