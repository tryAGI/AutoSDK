//HintName: G.Models.GenerateSpeechRequestModelVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Valid values: GEN2. Audio will be generated using the new and advanced GEN2 model. Outputs from GEN2 sound more natural and high-quality compared to earlier models.<br/>
    /// Default Value: GEN2
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerateSpeechRequestModelVersion
    {
        /// <summary>
        /// GEN2. Audio will be generated using the new and advanced GEN2 model. Outputs from GEN2 sound more natural and high-quality compared to earlier models.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GEN2")]
        Gen2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateSpeechRequestModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateSpeechRequestModelVersion value)
        {
            return value switch
            {
                GenerateSpeechRequestModelVersion.Gen2 => "GEN2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateSpeechRequestModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "GEN2" => GenerateSpeechRequestModelVersion.Gen2,
                _ => null,
            };
        }
    }
}