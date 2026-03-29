//HintName: G.Models.CreateTranslationRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTranslationRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whisper-large-v3")]
        WhisperLargeV3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="whisper-large-v3-turbo")]
        WhisperLargeV3Turbo,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTranslationRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTranslationRequestModel value)
        {
            return value switch
            {
                CreateTranslationRequestModel.WhisperLargeV3 => "whisper-large-v3",
                CreateTranslationRequestModel.WhisperLargeV3Turbo => "whisper-large-v3-turbo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTranslationRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "whisper-large-v3" => CreateTranslationRequestModel.WhisperLargeV3,
                "whisper-large-v3-turbo" => CreateTranslationRequestModel.WhisperLargeV3Turbo,
                _ => null,
            };
        }
    }
}