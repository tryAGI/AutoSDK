//HintName: G.Models.PlaygroundPromptCanvasPayloadArtifactLength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundPromptCanvasPayloadArtifactLength
    {
        /// <summary>
        /// 
        /// </summary>
        Long,
        /// <summary>
        /// 
        /// </summary>
        Longest,
        /// <summary>
        /// 
        /// </summary>
        Short,
        /// <summary>
        /// 
        /// </summary>
        Shortest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaygroundPromptCanvasPayloadArtifactLengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundPromptCanvasPayloadArtifactLength value)
        {
            return value switch
            {
                PlaygroundPromptCanvasPayloadArtifactLength.Long => "long",
                PlaygroundPromptCanvasPayloadArtifactLength.Longest => "longest",
                PlaygroundPromptCanvasPayloadArtifactLength.Short => "short",
                PlaygroundPromptCanvasPayloadArtifactLength.Shortest => "shortest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundPromptCanvasPayloadArtifactLength? ToEnum(string value)
        {
            return value switch
            {
                "long" => PlaygroundPromptCanvasPayloadArtifactLength.Long,
                "longest" => PlaygroundPromptCanvasPayloadArtifactLength.Longest,
                "short" => PlaygroundPromptCanvasPayloadArtifactLength.Short,
                "shortest" => PlaygroundPromptCanvasPayloadArtifactLength.Shortest,
                _ => null,
            };
        }
    }
}