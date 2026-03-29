//HintName: G.Models.ResearchDtoClassVariant2Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model used for the research request<br/>
    /// Default Value: exa-research
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchDtoClassVariant2Model
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
    public static class ResearchDtoClassVariant2ModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassVariant2Model value)
        {
            return value switch
            {
                ResearchDtoClassVariant2Model.ExaResearch => "exa-research",
                ResearchDtoClassVariant2Model.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassVariant2Model? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchDtoClassVariant2Model.ExaResearch,
                "exa-research-pro" => ResearchDtoClassVariant2Model.ExaResearchPro,
                _ => null,
            };
        }
    }
}