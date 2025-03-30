//HintName: G.Models.PlaygroundPromptCanvasPayloadTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundPromptCanvasPayloadTemplateFormat
    {
        /// <summary>
        /// 
        /// </summary>
        FString,
        /// <summary>
        /// 
        /// </summary>
        Mustache,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaygroundPromptCanvasPayloadTemplateFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundPromptCanvasPayloadTemplateFormat value)
        {
            return value switch
            {
                PlaygroundPromptCanvasPayloadTemplateFormat.FString => "f-string",
                PlaygroundPromptCanvasPayloadTemplateFormat.Mustache => "mustache",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundPromptCanvasPayloadTemplateFormat? ToEnum(string value)
        {
            return value switch
            {
                "f-string" => PlaygroundPromptCanvasPayloadTemplateFormat.FString,
                "mustache" => PlaygroundPromptCanvasPayloadTemplateFormat.Mustache,
                _ => null,
            };
        }
    }
}