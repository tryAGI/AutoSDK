//HintName: G.Models.PlaygroundPromptCanvasPayloadArtifactLength2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PlaygroundPromptCanvasPayloadArtifactLength2
    {
        /// <summary>
        /// 
        /// </summary>
        Shortest,
        /// <summary>
        /// 
        /// </summary>
        Short,
        /// <summary>
        /// 
        /// </summary>
        Long,
        /// <summary>
        /// 
        /// </summary>
        Longest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlaygroundPromptCanvasPayloadArtifactLength2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundPromptCanvasPayloadArtifactLength2 value)
        {
            return value switch
            {
                PlaygroundPromptCanvasPayloadArtifactLength2.Shortest => "shortest",
                PlaygroundPromptCanvasPayloadArtifactLength2.Short => "short",
                PlaygroundPromptCanvasPayloadArtifactLength2.Long => "long",
                PlaygroundPromptCanvasPayloadArtifactLength2.Longest => "longest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundPromptCanvasPayloadArtifactLength2? ToEnum(string value)
        {
            return value switch
            {
                "shortest" => PlaygroundPromptCanvasPayloadArtifactLength2.Shortest,
                "short" => PlaygroundPromptCanvasPayloadArtifactLength2.Short,
                "long" => PlaygroundPromptCanvasPayloadArtifactLength2.Long,
                "longest" => PlaygroundPromptCanvasPayloadArtifactLength2.Longest,
                _ => null,
            };
        }
    }
}