//HintName: G.Models.TranslateSpeechRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Speech-to-text model<br/>
    /// Default Value: saaras:v3
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslateSpeechRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="saaras:v3")]
        Saaras_v3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslateSpeechRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslateSpeechRequestModel value)
        {
            return value switch
            {
                TranslateSpeechRequestModel.Saaras_v3 => "saaras:v3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslateSpeechRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "saaras:v3" => TranslateSpeechRequestModel.Saaras_v3,
                _ => null,
            };
        }
    }
}