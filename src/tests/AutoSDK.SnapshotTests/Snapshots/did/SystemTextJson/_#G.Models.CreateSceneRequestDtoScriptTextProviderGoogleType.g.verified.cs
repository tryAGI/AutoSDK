//HintName: G.Models.CreateSceneRequestDtoScriptTextProviderGoogleType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSceneRequestDtoScriptTextProviderGoogleType
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSceneRequestDtoScriptTextProviderGoogleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSceneRequestDtoScriptTextProviderGoogleType value)
        {
            return value switch
            {
                CreateSceneRequestDtoScriptTextProviderGoogleType.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSceneRequestDtoScriptTextProviderGoogleType? ToEnum(string value)
        {
            return value switch
            {
                "google" => CreateSceneRequestDtoScriptTextProviderGoogleType.Google,
                _ => null,
            };
        }
    }
}