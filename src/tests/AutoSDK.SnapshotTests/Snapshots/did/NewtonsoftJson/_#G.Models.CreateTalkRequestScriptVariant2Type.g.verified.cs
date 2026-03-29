//HintName: G.Models.CreateTalkRequestScriptVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTalkRequestScriptVariant2Type
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
    public static class CreateTalkRequestScriptVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestScriptVariant2Type value)
        {
            return value switch
            {
                CreateTalkRequestScriptVariant2Type.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestScriptVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateTalkRequestScriptVariant2Type.Audio,
                _ => null,
            };
        }
    }
}