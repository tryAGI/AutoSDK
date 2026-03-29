//HintName: G.Models.CreateResearchRequestCitationFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format for citations in the research report.<br/>
    /// Default Value: numbered
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateResearchRequestCitationFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="apa")]
        Apa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chicago")]
        Chicago,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mla")]
        Mla,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="numbered")]
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