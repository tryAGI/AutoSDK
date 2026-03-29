//HintName: G.Models.GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GeminiMultimodalLivePrebuiltVoiceConfigVoiceName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Aoede")]
        Aoede,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Charon")]
        Charon,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Fenrir")]
        Fenrir,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Kore")]
        Kore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Puck")]
        Puck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GeminiMultimodalLivePrebuiltVoiceConfigVoiceNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GeminiMultimodalLivePrebuiltVoiceConfigVoiceName value)
        {
            return value switch
            {
                GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Aoede => "Aoede",
                GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Charon => "Charon",
                GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Fenrir => "Fenrir",
                GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Kore => "Kore",
                GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Puck => "Puck",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GeminiMultimodalLivePrebuiltVoiceConfigVoiceName? ToEnum(string value)
        {
            return value switch
            {
                "Aoede" => GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Aoede,
                "Charon" => GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Charon,
                "Fenrir" => GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Fenrir,
                "Kore" => GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Kore,
                "Puck" => GeminiMultimodalLivePrebuiltVoiceConfigVoiceName.Puck,
                _ => null,
            };
        }
    }
}