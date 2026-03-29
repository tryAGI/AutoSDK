//HintName: G.Models.CreateModelRequestType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model type, tts is for text to speech
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelRequestType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tts")]
        Tts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelRequestType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelRequestType2 value)
        {
            return value switch
            {
                CreateModelRequestType2.Tts => "tts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelRequestType2? ToEnum(string value)
        {
            return value switch
            {
                "tts" => CreateModelRequestType2.Tts,
                _ => null,
            };
        }
    }
}