//HintName: G.Models.NeuphonicVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used. Defaults to 'neu_fast' if not specified.<br/>
    /// Example: neu_fast
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum NeuphonicVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neu_fast")]
        NeuFast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neu_hq")]
        NeuHq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NeuphonicVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NeuphonicVoiceModel value)
        {
            return value switch
            {
                NeuphonicVoiceModel.NeuFast => "neu_fast",
                NeuphonicVoiceModel.NeuHq => "neu_hq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NeuphonicVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "neu_fast" => NeuphonicVoiceModel.NeuFast,
                "neu_hq" => NeuphonicVoiceModel.NeuHq,
                _ => null,
            };
        }
    }
}