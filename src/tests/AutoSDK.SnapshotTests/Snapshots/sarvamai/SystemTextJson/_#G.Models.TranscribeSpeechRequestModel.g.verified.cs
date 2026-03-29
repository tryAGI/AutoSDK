//HintName: G.Models.TranscribeSpeechRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Speech-to-text model<br/>
    /// Default Value: saarika:v2.5
    /// </summary>
    public enum TranscribeSpeechRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Saaras_v3,
        /// <summary>
        /// 
        /// </summary>
        Saarika_v25,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscribeSpeechRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscribeSpeechRequestModel value)
        {
            return value switch
            {
                TranscribeSpeechRequestModel.Saaras_v3 => "saaras:v3",
                TranscribeSpeechRequestModel.Saarika_v25 => "saarika:v2.5",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscribeSpeechRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "saaras:v3" => TranscribeSpeechRequestModel.Saaras_v3,
                "saarika:v2.5" => TranscribeSpeechRequestModel.Saarika_v25,
                _ => null,
            };
        }
    }
}