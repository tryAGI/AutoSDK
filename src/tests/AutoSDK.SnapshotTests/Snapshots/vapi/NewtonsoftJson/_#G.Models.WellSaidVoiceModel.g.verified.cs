//HintName: G.Models.WellSaidVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WellSaidVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="caruso")]
        Caruso,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="legacy")]
        Legacy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WellSaidVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WellSaidVoiceModel value)
        {
            return value switch
            {
                WellSaidVoiceModel.Caruso => "caruso",
                WellSaidVoiceModel.Legacy => "legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WellSaidVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "caruso" => WellSaidVoiceModel.Caruso,
                "legacy" => WellSaidVoiceModel.Legacy,
                _ => null,
            };
        }
    }
}