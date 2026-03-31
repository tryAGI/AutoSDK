//HintName: G.Models.InternalCallConfigInferenceMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InternalCallConfigInferenceMode
    {
        /// <summary>
        /// 
        /// </summary>
        Idle,
        /// <summary>
        /// 
        /// </summary>
        Talk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InternalCallConfigInferenceModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternalCallConfigInferenceMode value)
        {
            return value switch
            {
                InternalCallConfigInferenceMode.Idle => "idle",
                InternalCallConfigInferenceMode.Talk => "talk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternalCallConfigInferenceMode? ToEnum(string value)
        {
            return value switch
            {
                "idle" => InternalCallConfigInferenceMode.Idle,
                "talk" => InternalCallConfigInferenceMode.Talk,
                _ => null,
            };
        }
    }
}