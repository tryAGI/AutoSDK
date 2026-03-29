//HintName: G.Models.FallbackRimeAIVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used. Defaults to 'arcana' when not specified.<br/>
    /// Example: arcana
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackRimeAIVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="arcana")]
        Arcana,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mist")]
        Mist,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistv2")]
        Mistv2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackRimeAIVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackRimeAIVoiceModel value)
        {
            return value switch
            {
                FallbackRimeAIVoiceModel.Arcana => "arcana",
                FallbackRimeAIVoiceModel.Mist => "mist",
                FallbackRimeAIVoiceModel.Mistv2 => "mistv2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackRimeAIVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "arcana" => FallbackRimeAIVoiceModel.Arcana,
                "mist" => FallbackRimeAIVoiceModel.Mist,
                "mistv2" => FallbackRimeAIVoiceModel.Mistv2,
                _ => null,
            };
        }
    }
}