//HintName: G.Models.PlaygroundPromptCanvasPayloadArtifactLength.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PlaygroundPromptCanvasPayloadArtifactLength
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shortest")]
        Shortest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="short")]
        Short,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="long")]
        Long,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="longest")]
        Longest,
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
                PlaygroundPromptCanvasPayloadArtifactLength.Shortest => "shortest",
                PlaygroundPromptCanvasPayloadArtifactLength.Short => "short",
                PlaygroundPromptCanvasPayloadArtifactLength.Long => "long",
                PlaygroundPromptCanvasPayloadArtifactLength.Longest => "longest",
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
                "shortest" => PlaygroundPromptCanvasPayloadArtifactLength.Shortest,
                "short" => PlaygroundPromptCanvasPayloadArtifactLength.Short,
                "long" => PlaygroundPromptCanvasPayloadArtifactLength.Long,
                "longest" => PlaygroundPromptCanvasPayloadArtifactLength.Longest,
                _ => null,
            };
        }
    }
}