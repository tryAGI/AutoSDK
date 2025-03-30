//HintName: G.Models.PlaygroundPromptCanvasPayloadReadingLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundPromptCanvasPayloadReadingLevel
    {
        /// <summary>
        /// 
        /// </summary>
        Child,
        /// <summary>
        /// 
        /// </summary>
        Teenager,
        /// <summary>
        /// 
        /// </summary>
        College,
        /// <summary>
        /// 
        /// </summary>
        Phd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaygroundPromptCanvasPayloadReadingLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundPromptCanvasPayloadReadingLevel value)
        {
            return value switch
            {
                PlaygroundPromptCanvasPayloadReadingLevel.Child => "child",
                PlaygroundPromptCanvasPayloadReadingLevel.Teenager => "teenager",
                PlaygroundPromptCanvasPayloadReadingLevel.College => "college",
                PlaygroundPromptCanvasPayloadReadingLevel.Phd => "phd",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundPromptCanvasPayloadReadingLevel? ToEnum(string value)
        {
            return value switch
            {
                "child" => PlaygroundPromptCanvasPayloadReadingLevel.Child,
                "teenager" => PlaygroundPromptCanvasPayloadReadingLevel.Teenager,
                "college" => PlaygroundPromptCanvasPayloadReadingLevel.College,
                "phd" => PlaygroundPromptCanvasPayloadReadingLevel.Phd,
                _ => null,
            };
        }
    }
}