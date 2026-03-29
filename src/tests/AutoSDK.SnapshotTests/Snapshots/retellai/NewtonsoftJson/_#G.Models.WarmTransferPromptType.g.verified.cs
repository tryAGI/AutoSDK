//HintName: G.Models.WarmTransferPromptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WarmTransferPromptType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WarmTransferPromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WarmTransferPromptType value)
        {
            return value switch
            {
                WarmTransferPromptType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WarmTransferPromptType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => WarmTransferPromptType.Prompt,
                _ => null,
            };
        }
    }
}