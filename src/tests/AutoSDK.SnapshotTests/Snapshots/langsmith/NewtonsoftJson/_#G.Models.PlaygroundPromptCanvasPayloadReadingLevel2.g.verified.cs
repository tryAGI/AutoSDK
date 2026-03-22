//HintName: G.Models.PlaygroundPromptCanvasPayloadReadingLevel2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PlaygroundPromptCanvasPayloadReadingLevel2
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
    public static class PlaygroundPromptCanvasPayloadReadingLevel2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlaygroundPromptCanvasPayloadReadingLevel2 value)
        {
            return value switch
            {
                PlaygroundPromptCanvasPayloadReadingLevel2.Child => "child",
                PlaygroundPromptCanvasPayloadReadingLevel2.College => "college",
                PlaygroundPromptCanvasPayloadReadingLevel2.Phd => "phd",
                PlaygroundPromptCanvasPayloadReadingLevel2.Teenager => "teenager",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlaygroundPromptCanvasPayloadReadingLevel2? ToEnum(string value)
        {
            return value switch
            {
                "child" => PlaygroundPromptCanvasPayloadReadingLevel2.Child,
                "college" => PlaygroundPromptCanvasPayloadReadingLevel2.College,
                "phd" => PlaygroundPromptCanvasPayloadReadingLevel2.Phd,
                "teenager" => PlaygroundPromptCanvasPayloadReadingLevel2.Teenager,
                _ => null,
            };
        }
    }
}