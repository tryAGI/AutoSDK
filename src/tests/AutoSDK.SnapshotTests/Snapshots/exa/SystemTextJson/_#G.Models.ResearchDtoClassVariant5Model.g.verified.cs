//HintName: G.Models.ResearchDtoClassVariant5Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model used for the research request<br/>
    /// Default Value: exa-research
    /// </summary>
    public enum ResearchDtoClassVariant5Model
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
    public static class ResearchDtoClassVariant5ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassVariant5Model value)
        {
            return value switch
            {
                ResearchDtoClassVariant5Model.ExaResearch => "exa-research",
                ResearchDtoClassVariant5Model.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassVariant5Model? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchDtoClassVariant5Model.ExaResearch,
                "exa-research-pro" => ResearchDtoClassVariant5Model.ExaResearchPro,
                _ => null,
            };
        }
    }
}