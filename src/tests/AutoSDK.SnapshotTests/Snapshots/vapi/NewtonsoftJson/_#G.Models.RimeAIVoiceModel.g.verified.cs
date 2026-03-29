//HintName: G.Models.RimeAIVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used. Defaults to 'arcana' when not specified.<br/>
    /// Example: arcana
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RimeAIVoiceModel
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
    public static class RimeAIVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RimeAIVoiceModel value)
        {
            return value switch
            {
                RimeAIVoiceModel.Arcana => "arcana",
                RimeAIVoiceModel.Mist => "mist",
                RimeAIVoiceModel.Mistv2 => "mistv2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RimeAIVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "arcana" => RimeAIVoiceModel.Arcana,
                "mist" => RimeAIVoiceModel.Mist,
                "mistv2" => RimeAIVoiceModel.Mistv2,
                _ => null,
            };
        }
    }
}