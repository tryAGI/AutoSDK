//HintName: G.Models.CreateExpressiveRequestDtoScriptVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    public enum CreateExpressiveRequestDtoScriptVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateExpressiveRequestDtoScriptVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressiveRequestDtoScriptVariant2Type value)
        {
            return value switch
            {
                CreateExpressiveRequestDtoScriptVariant2Type.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressiveRequestDtoScriptVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateExpressiveRequestDtoScriptVariant2Type.Audio,
                _ => null,
            };
        }
    }
}