//HintName: G.Models.FallbackWellSaidVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used.
    /// </summary>
    public enum FallbackWellSaidVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        Caruso,
        /// <summary>
        /// 
        /// </summary>
        Legacy,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackWellSaidVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackWellSaidVoiceModel value)
        {
            return value switch
            {
                FallbackWellSaidVoiceModel.Caruso => "caruso",
                FallbackWellSaidVoiceModel.Legacy => "legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackWellSaidVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "caruso" => FallbackWellSaidVoiceModel.Caruso,
                "legacy" => FallbackWellSaidVoiceModel.Legacy,
                _ => null,
            };
        }
    }
}