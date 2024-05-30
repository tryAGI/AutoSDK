//HintName: G.Models.CreateAssistantRequestResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `auto` is the default value
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateAssistantRequestResponseFormat
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

    public static class CreateAssistantRequestResponseFormatExtensions
    {
        public static string ToValueString(this CreateAssistantRequestResponseFormat value)
        {
            return value switch
            {
                CreateAssistantRequestResponseFormat.None => "none",
                CreateAssistantRequestResponseFormat.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateAssistantRequestResponseFormat ToEnum(string value)
        {
            return value switch
            {
                "none" => CreateAssistantRequestResponseFormat.None,
                "auto" => CreateAssistantRequestResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateAssistantRequestResponseFormat ToEnum(int value)
        {
            return value switch
            {
                0 => CreateAssistantRequestResponseFormat.None,
                1 => CreateAssistantRequestResponseFormat.Auto,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}