//HintName: G.Models.CreateSceneRequestDtoScriptTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the script.
    /// </summary>
    public enum CreateSceneRequestDtoScriptTextType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSceneRequestDtoScriptTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSceneRequestDtoScriptTextType value)
        {
            return value switch
            {
                CreateSceneRequestDtoScriptTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSceneRequestDtoScriptTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => CreateSceneRequestDtoScriptTextType.Text,
                _ => null,
            };
        }
    }
}