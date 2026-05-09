//HintName: G.Models.CreateTextToSpeechRequestDiscriminatorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTextToSpeechRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_multilingual_v2")]
        ElevenMultilingualV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTextToSpeechRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToSpeechRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateTextToSpeechRequestDiscriminatorModel.ElevenMultilingualV2 => "eleven_multilingual_v2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToSpeechRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_multilingual_v2" => CreateTextToSpeechRequestDiscriminatorModel.ElevenMultilingualV2,
                _ => null,
            };
        }
    }
}