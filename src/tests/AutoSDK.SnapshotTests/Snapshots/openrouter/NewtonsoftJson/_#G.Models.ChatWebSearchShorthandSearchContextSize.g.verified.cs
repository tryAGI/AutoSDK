//HintName: G.Models.ChatWebSearchShorthandSearchContextSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How much context to retrieve per result. Defaults to medium (15000 chars). Only applies when using the Exa engine; ignored with native provider search.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatWebSearchShorthandSearchContextSize
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatWebSearchShorthandSearchContextSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatWebSearchShorthandSearchContextSize value)
        {
            return value switch
            {
                ChatWebSearchShorthandSearchContextSize.High => "high",
                ChatWebSearchShorthandSearchContextSize.Low => "low",
                ChatWebSearchShorthandSearchContextSize.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatWebSearchShorthandSearchContextSize? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatWebSearchShorthandSearchContextSize.High,
                "low" => ChatWebSearchShorthandSearchContextSize.Low,
                "medium" => ChatWebSearchShorthandSearchContextSize.Medium,
                _ => null,
            };
        }
    }
}