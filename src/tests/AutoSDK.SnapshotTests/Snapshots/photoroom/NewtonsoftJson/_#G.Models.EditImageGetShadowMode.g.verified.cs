//HintName: G.Models.EditImageGetShadowMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetShadowMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.floating")]
        AiFloating,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.hard")]
        AiHard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.soft")]
        AiSoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetShadowModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetShadowMode value)
        {
            return value switch
            {
                EditImageGetShadowMode.AiFloating => "ai.floating",
                EditImageGetShadowMode.AiHard => "ai.hard",
                EditImageGetShadowMode.AiSoft => "ai.soft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetShadowMode? ToEnum(string value)
        {
            return value switch
            {
                "ai.floating" => EditImageGetShadowMode.AiFloating,
                "ai.hard" => EditImageGetShadowMode.AiHard,
                "ai.soft" => EditImageGetShadowMode.AiSoft,
                _ => null,
            };
        }
    }
}