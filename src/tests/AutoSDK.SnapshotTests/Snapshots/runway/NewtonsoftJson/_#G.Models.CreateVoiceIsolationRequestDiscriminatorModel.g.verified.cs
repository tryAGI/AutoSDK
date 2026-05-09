//HintName: G.Models.CreateVoiceIsolationRequestDiscriminatorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVoiceIsolationRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_voice_isolation")]
        ElevenVoiceIsolation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVoiceIsolationRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoiceIsolationRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateVoiceIsolationRequestDiscriminatorModel.ElevenVoiceIsolation => "eleven_voice_isolation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoiceIsolationRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_voice_isolation" => CreateVoiceIsolationRequestDiscriminatorModel.ElevenVoiceIsolation,
                _ => null,
            };
        }
    }
}