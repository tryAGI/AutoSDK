//HintName: G.Models.CreateSpeechmaticsCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSpeechmaticsCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="speechmatics")]
        Speechmatics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechmaticsCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechmaticsCredentialDTOProvider value)
        {
            return value switch
            {
                CreateSpeechmaticsCredentialDTOProvider.Speechmatics => "speechmatics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechmaticsCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "speechmatics" => CreateSpeechmaticsCredentialDTOProvider.Speechmatics,
                _ => null,
            };
        }
    }
}