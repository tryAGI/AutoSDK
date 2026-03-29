//HintName: G.Models.ResearchCreateRequestDtoClassModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: exa-research
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ResearchCreateRequestDtoClassModel
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
    public static class ResearchCreateRequestDtoClassModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchCreateRequestDtoClassModel value)
        {
            return value switch
            {
                ResearchCreateRequestDtoClassModel.ExaResearch => "exa-research",
                ResearchCreateRequestDtoClassModel.ExaResearchPro => "exa-research-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchCreateRequestDtoClassModel? ToEnum(string value)
        {
            return value switch
            {
                "exa-research" => ResearchCreateRequestDtoClassModel.ExaResearch,
                "exa-research-pro" => ResearchCreateRequestDtoClassModel.ExaResearchPro,
                _ => null,
            };
        }
    }
}