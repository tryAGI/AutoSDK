//HintName: G.Models.ResearchDtoClassVariant1Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model used for the research request<br/>
    /// Default Value: exa-research
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchDtoClassVariant1Model
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exa-research")]
        ExaResearch,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="exa-research-pro")]
        ExaResearchPro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassVariant1ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassVariant1Model value)
        {
            return value switch
            {
                ResearchDtoClassVariant1Model.ExaResearch => "exa-research",
                ResearchDtoClassVariant1Model.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassVariant1Model? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchDtoClassVariant1Model.ExaResearch,
                "exa-research-pro" => ResearchDtoClassVariant1Model.ExaResearchPro,
                _ => null,
            };
        }
    }
}