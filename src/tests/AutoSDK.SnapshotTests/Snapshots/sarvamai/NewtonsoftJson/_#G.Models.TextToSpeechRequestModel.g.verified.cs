//HintName: G.Models.TextToSpeechRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// TTS model to use<br/>
    /// Default Value: bulbul:v3
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TextToSpeechRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bulbul:v2")]
        Bulbul_v2,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bulbul:v3")]
        Bulbul_v3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToSpeechRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToSpeechRequestModel value)
        {
            return value switch
            {
                TextToSpeechRequestModel.Bulbul_v2 => "bulbul:v2",
                TextToSpeechRequestModel.Bulbul_v3 => "bulbul:v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToSpeechRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "bulbul:v2" => TextToSpeechRequestModel.Bulbul_v2,
                "bulbul:v3" => TextToSpeechRequestModel.Bulbul_v3,
                _ => null,
            };
        }
    }
}