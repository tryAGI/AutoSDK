//HintName: G.Models.UnifiedCreateVideoStreamRequestScriptTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UnifiedCreateVideoStreamRequestScriptTextType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedCreateVideoStreamRequestScriptTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedCreateVideoStreamRequestScriptTextType value)
        {
            return value switch
            {
                UnifiedCreateVideoStreamRequestScriptTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedCreateVideoStreamRequestScriptTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => UnifiedCreateVideoStreamRequestScriptTextType.Text,
                _ => null,
            };
        }
    }
}