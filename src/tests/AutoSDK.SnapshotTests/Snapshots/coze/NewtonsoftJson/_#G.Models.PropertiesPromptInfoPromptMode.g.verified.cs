//HintName: G.Models.PropertiesPromptInfoPromptMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 提示词模式
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesPromptInfoPromptMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefix")]
        Prefix,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="standard")]
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesPromptInfoPromptModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesPromptInfoPromptMode value)
        {
            return value switch
            {
                PropertiesPromptInfoPromptMode.Prefix => "prefix",
                PropertiesPromptInfoPromptMode.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesPromptInfoPromptMode? ToEnum(string value)
        {
            return value switch
            {
                "prefix" => PropertiesPromptInfoPromptMode.Prefix,
                "standard" => PropertiesPromptInfoPromptMode.Standard,
                _ => null,
            };
        }
    }
}