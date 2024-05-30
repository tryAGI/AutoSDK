//HintName: G.Models.ModifyAssistantRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModifyAssistantRequestResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    public static class ModifyAssistantRequestResponseFormatExtensions
    {
        public static string ToValueString(this ModifyAssistantRequestResponseFormat value)
        {
            return value switch
            {
                ModifyAssistantRequestResponseFormat.None => "none",
                ModifyAssistantRequestResponseFormat.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ModifyAssistantRequestResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "none" => ModifyAssistantRequestResponseFormat.None,
                "auto" => ModifyAssistantRequestResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ModifyAssistantRequestResponseFormat ToEnum(int value)
        {
            return value switch
            {
                0 => ModifyAssistantRequestResponseFormat.None,
                1 => ModifyAssistantRequestResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}