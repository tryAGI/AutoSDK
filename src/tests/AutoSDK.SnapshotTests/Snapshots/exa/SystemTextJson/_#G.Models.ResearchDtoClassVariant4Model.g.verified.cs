//HintName: G.Models.ResearchDtoClassVariant4Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model used for the research request<br/>
    /// Default Value: exa-research
    /// </summary>
    public enum ResearchDtoClassVariant4Model
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
    public static class ResearchDtoClassVariant4ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassVariant4Model value)
        {
            return value switch
            {
                ResearchDtoClassVariant4Model.ExaResearch => "exa-research",
                ResearchDtoClassVariant4Model.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassVariant4Model? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchDtoClassVariant4Model.ExaResearch,
                "exa-research-pro" => ResearchDtoClassVariant4Model.ExaResearchPro,
                _ => null,
            };
        }
    }
}