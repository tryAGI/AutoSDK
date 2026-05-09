//HintName: G.Models.CreateSpeechToSpeechRequestDiscriminatorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSpeechToSpeechRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_multilingual_sts_v2")]
        ElevenMultilingualStsV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechToSpeechRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechToSpeechRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateSpeechToSpeechRequestDiscriminatorModel.ElevenMultilingualStsV2 => "eleven_multilingual_sts_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechToSpeechRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_multilingual_sts_v2" => CreateSpeechToSpeechRequestDiscriminatorModel.ElevenMultilingualStsV2,
                _ => null,
            };
        }
    }
}