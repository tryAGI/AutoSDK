//HintName: G.Models.PlaygroundPromptCanvasPayloadReadingLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PlaygroundPromptCanvasPayloadReadingLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="child")]
        Child,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="college")]
        College,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phd")]
        Phd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="teenager")]
        Teenager,
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
                PlaygroundPromptCanvasPayloadReadingLevel.College => "college",
                PlaygroundPromptCanvasPayloadReadingLevel.Phd => "phd",
                PlaygroundPromptCanvasPayloadReadingLevel.Teenager => "teenager",
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
                "college" => PlaygroundPromptCanvasPayloadReadingLevel.College,
                "phd" => PlaygroundPromptCanvasPayloadReadingLevel.Phd,
                "teenager" => PlaygroundPromptCanvasPayloadReadingLevel.Teenager,
                _ => null,
            };
        }
    }
}