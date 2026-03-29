//HintName: G.Models.CreateTalkStreamRequestScriptVariant2Type2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkStreamRequestScriptVariant2Type2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTalkStreamRequestScriptVariant2Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkStreamRequestScriptVariant2Type2 value)
        {
            return value switch
            {
                CreateTalkStreamRequestScriptVariant2Type2.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkStreamRequestScriptVariant2Type2? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateTalkStreamRequestScriptVariant2Type2.Audio,
                _ => null,
            };
        }
    }
}