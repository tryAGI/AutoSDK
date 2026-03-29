//HintName: G.Models.FallbackSesameVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackSesameVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="csm-1b")]
        Csm1b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackSesameVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackSesameVoiceModel value)
        {
            return value switch
            {
                FallbackSesameVoiceModel.Csm1b => "csm-1b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackSesameVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "csm-1b" => FallbackSesameVoiceModel.Csm1b,
                _ => null,
            };
        }
    }
}