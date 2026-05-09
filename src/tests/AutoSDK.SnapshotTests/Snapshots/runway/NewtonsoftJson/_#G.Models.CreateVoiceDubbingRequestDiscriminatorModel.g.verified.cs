//HintName: G.Models.CreateVoiceDubbingRequestDiscriminatorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVoiceDubbingRequestDiscriminatorModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eleven_voice_dubbing")]
        ElevenVoiceDubbing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVoiceDubbingRequestDiscriminatorModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVoiceDubbingRequestDiscriminatorModel value)
        {
            return value switch
            {
                CreateVoiceDubbingRequestDiscriminatorModel.ElevenVoiceDubbing => "eleven_voice_dubbing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVoiceDubbingRequestDiscriminatorModel? ToEnum(string value)
        {
            return value switch
            {
                "eleven_voice_dubbing" => CreateVoiceDubbingRequestDiscriminatorModel.ElevenVoiceDubbing,
                _ => null,
            };
        }
    }
}