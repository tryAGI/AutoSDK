//HintName: G.Models.AgreementMethodologyEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `consensus` - Consensus<br/>
    /// * `pairwise` - Pairwise Averaging
    /// </summary>
    public enum AgreementMethodologyEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Consensus,
        /// <summary>
        /// 
        /// </summary>
        Pairwise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgreementMethodologyEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgreementMethodologyEnum value)
        {
            return value switch
            {
                AgreementMethodologyEnum.Consensus => "consensus",
                AgreementMethodologyEnum.Pairwise => "pairwise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgreementMethodologyEnum? ToEnum(string value)
        {
            return value switch
            {
                "consensus" => AgreementMethodologyEnum.Consensus,
                "pairwise" => AgreementMethodologyEnum.Pairwise,
                _ => null,
            };
        }
    }
}