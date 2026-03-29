//HintName: G.Models.CreateResearchRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The model used by the research agent. "mini" is optimized for targeted, efficient research and works best for narrow or well-scoped questions. "pro" provides comprehensive, multi-angle research and is suited for complex topics that span multiple subtopics or domains<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateResearchRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mini")]
        Mini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pro")]
        Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResearchRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResearchRequestModel value)
        {
            return value switch
            {
                CreateResearchRequestModel.Auto => "auto",
                CreateResearchRequestModel.Mini => "mini",
                CreateResearchRequestModel.Pro => "pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResearchRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "auto" => CreateResearchRequestModel.Auto,
                "mini" => CreateResearchRequestModel.Mini,
                "pro" => CreateResearchRequestModel.Pro,
                _ => null,
            };
        }
    }
}