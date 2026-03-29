//HintName: G.Models.EditImageGetUpscaleMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EditImageGetUpscaleMode
    {
        /// <summary>
        /// This algorithm is optimized for speed and may not produce the highest quality results. ai.slow: This algorithm is optimized for quality and may take more time to process.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.fast")]
        AiFast,
        /// <summary>
        /// This algorithm is optimized for speed and may not produce the highest quality results. ai.slow: This algorithm is optimized for quality and may take more time to process.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai.slow")]
        AiSlow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditImageGetUpscaleModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditImageGetUpscaleMode value)
        {
            return value switch
            {
                EditImageGetUpscaleMode.AiFast => "ai.fast",
                EditImageGetUpscaleMode.AiSlow => "ai.slow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditImageGetUpscaleMode? ToEnum(string value)
        {
            return value switch
            {
                "ai.fast" => EditImageGetUpscaleMode.AiFast,
                "ai.slow" => EditImageGetUpscaleMode.AiSlow,
                _ => null,
            };
        }
    }
}