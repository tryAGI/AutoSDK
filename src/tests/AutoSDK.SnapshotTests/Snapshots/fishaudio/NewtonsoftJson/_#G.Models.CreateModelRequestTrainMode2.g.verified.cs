//HintName: G.Models.CreateModelRequestTrainMode2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model train mode, for TTS model, fast means model instantly available after creation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelRequestTrainMode2
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
    public static class CreateModelRequestTrainMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelRequestTrainMode2 value)
        {
            return value switch
            {
                CreateModelRequestTrainMode2.Fast => "fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelRequestTrainMode2? ToEnum(string value)
        {
            return value switch
            {
                "fast" => CreateModelRequestTrainMode2.Fast,
                _ => null,
            };
        }
    }
}