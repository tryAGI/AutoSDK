//HintName: G.Models.CreateResearchRequestCitationFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format for citations in the research report.<br/>
    /// Default Value: numbered
    /// </summary>
    public enum CreateResearchRequestCitationFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Apa,
        /// <summary>
        /// 
        /// </summary>
        Chicago,
        /// <summary>
        /// 
        /// </summary>
        Mla,
        /// <summary>
        /// 
        /// </summary>
        Numbered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResearchRequestCitationFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResearchRequestCitationFormat value)
        {
            return value switch
            {
                CreateResearchRequestCitationFormat.Apa => "apa",
                CreateResearchRequestCitationFormat.Chicago => "chicago",
                CreateResearchRequestCitationFormat.Mla => "mla",
                CreateResearchRequestCitationFormat.Numbered => "numbered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResearchRequestCitationFormat? ToEnum(string value)
        {
            return value switch
            {
                "apa" => CreateResearchRequestCitationFormat.Apa,
                "chicago" => CreateResearchRequestCitationFormat.Chicago,
                "mla" => CreateResearchRequestCitationFormat.Mla,
                "numbered" => CreateResearchRequestCitationFormat.Numbered,
                _ => null,
            };
        }
    }
}