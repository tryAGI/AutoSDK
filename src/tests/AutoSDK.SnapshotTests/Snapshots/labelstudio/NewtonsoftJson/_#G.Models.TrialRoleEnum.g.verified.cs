//HintName: G.Models.TrialRoleEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `annotator` - Annotator<br/>
    /// * `annotator_team_manager` - Annotator Team Manager<br/>
    /// * `business_analyst` - Business Analyst<br/>
    /// * `business_or_data_team_leadership` - Business Or Data Team Leadership<br/>
    /// * `data_engineer_platform_engineer` - Data Engineer Platform Engineer<br/>
    /// * `data_scientist` - Data Scientist<br/>
    /// * `other` - Other
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TrialRoleEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="annotator")]
        Annotator,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="annotator_team_manager")]
        AnnotatorTeamManager,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="business_analyst")]
        BusinessAnalyst,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="business_or_data_team_leadership")]
        BusinessOrDataTeamLeadership,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="data_engineer_platform_engineer")]
        DataEngineerPlatformEngineer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="data_scientist")]
        DataScientist,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="other")]
        Other,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TrialRoleEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrialRoleEnum value)
        {
            return value switch
            {
                TrialRoleEnum.Annotator => "annotator",
                TrialRoleEnum.AnnotatorTeamManager => "annotator_team_manager",
                TrialRoleEnum.BusinessAnalyst => "business_analyst",
                TrialRoleEnum.BusinessOrDataTeamLeadership => "business_or_data_team_leadership",
                TrialRoleEnum.DataEngineerPlatformEngineer => "data_engineer_platform_engineer",
                TrialRoleEnum.DataScientist => "data_scientist",
                TrialRoleEnum.Other => "other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrialRoleEnum? ToEnum(string value)
        {
            return value switch
            {
                "annotator" => TrialRoleEnum.Annotator,
                "annotator_team_manager" => TrialRoleEnum.AnnotatorTeamManager,
                "business_analyst" => TrialRoleEnum.BusinessAnalyst,
                "business_or_data_team_leadership" => TrialRoleEnum.BusinessOrDataTeamLeadership,
                "data_engineer_platform_engineer" => TrialRoleEnum.DataEngineerPlatformEngineer,
                "data_scientist" => TrialRoleEnum.DataScientist,
                "other" => TrialRoleEnum.Other,
                _ => null,
            };
        }
    }
}