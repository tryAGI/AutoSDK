//HintName: G.Models.SesameVoiceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that will be used.
    /// </summary>
    public enum SesameVoiceModel
    {
        /// <summary>
        /// 
        /// </summary>
        Csm1b,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SesameVoiceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SesameVoiceModel value)
        {
            return value switch
            {
                SesameVoiceModel.Csm1b => "csm-1b",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SesameVoiceModel? ToEnum(string value)
        {
            return value switch
            {
                "csm-1b" => SesameVoiceModel.Csm1b,
                _ => null,
            };
        }
    }
}