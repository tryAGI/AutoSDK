//HintName: G.Models.CreateModelRequestTrainMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model train mode, for TTS model, fast means model instantly available after creation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelRequestTrainMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fast")]
        Fast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelRequestTrainModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelRequestTrainMode value)
        {
            return value switch
            {
                CreateModelRequestTrainMode.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelRequestTrainMode? ToEnum(string value)
        {
            return value switch
            {
                "fast" => CreateModelRequestTrainMode.Fast,
                _ => null,
            };
        }
    }
}