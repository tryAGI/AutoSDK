//HintName: G.Models.PlaygroundPromptCanvasPayloadTemplateFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PlaygroundPromptCanvasPayloadTemplateFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="f-string")]
        FString,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mustache")]
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