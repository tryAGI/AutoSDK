//HintName: G.Models.FallbackNeuphonicVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used. Defaults to 'neu_fast' if not specified.<br/>
    /// Example: neu_fast
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackNeuphonicVoiceModel
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
    public static class FallbackNeuphonicVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackNeuphonicVoiceModel value)
        {
            return value switch
            {
                FallbackNeuphonicVoiceModel.NeuFast => "neu_fast",
                FallbackNeuphonicVoiceModel.NeuHq => "neu_hq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackNeuphonicVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "neu_fast" => FallbackNeuphonicVoiceModel.NeuFast,
                "neu_hq" => FallbackNeuphonicVoiceModel.NeuHq,
                _ => null,
            };
        }
    }
}