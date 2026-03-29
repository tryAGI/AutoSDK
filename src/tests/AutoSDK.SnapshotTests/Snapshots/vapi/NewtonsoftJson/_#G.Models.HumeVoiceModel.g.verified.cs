//HintName: G.Models.HumeVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used.<br/>
    /// Example: octave2
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HumeVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="octave")]
        Octave,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="octave2")]
        Octave2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HumeVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HumeVoiceModel value)
        {
            return value switch
            {
                HumeVoiceModel.Octave => "octave",
                HumeVoiceModel.Octave2 => "octave2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HumeVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "octave" => HumeVoiceModel.Octave,
                "octave2" => HumeVoiceModel.Octave2,
                _ => null,
            };
        }
    }
}