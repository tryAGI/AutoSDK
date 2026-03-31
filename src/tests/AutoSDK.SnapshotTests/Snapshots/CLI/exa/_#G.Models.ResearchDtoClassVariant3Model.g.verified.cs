//HintName: G.Models.ResearchDtoClassVariant3Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model used for the research request<br/>
    /// Default Value: exa-research
    /// </summary>
    public enum ResearchDtoClassVariant3Model
    {
        /// <summary>
        /// 
        /// </summary>
        ExaResearch,
        /// <summary>
        /// 
        /// </summary>
        ExaResearchPro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassVariant3ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassVariant3Model value)
        {
            return value switch
            {
                ResearchDtoClassVariant3Model.ExaResearch => "exa-research",
                ResearchDtoClassVariant3Model.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassVariant3Model? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchDtoClassVariant3Model.ExaResearch,
                "exa-research-pro" => ResearchDtoClassVariant3Model.ExaResearchPro,
                _ => null,
            };
        }
    }
}