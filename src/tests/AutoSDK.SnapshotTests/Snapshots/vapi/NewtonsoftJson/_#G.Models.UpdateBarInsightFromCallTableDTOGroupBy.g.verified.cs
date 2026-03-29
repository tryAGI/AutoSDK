//HintName: G.Models.UpdateBarInsightFromCallTableDTOGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the group by column for the insight when table is `call`.<br/>
    /// These are the columns to group the results by.<br/>
    /// All results are grouped by the time range step by default.<br/>
    /// Example: [assistant_id]
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateBarInsightFromCallTableDTOGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="artifact.structuredOutputs[OutputID]")]
        ArtifactStructuredOutputsOutputID,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistantId")]
        AssistantId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="campaignId")]
        CampaignId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="customerNumber")]
        CustomerNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="endedReason")]
        EndedReason,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phoneNumberId")]
        PhoneNumberId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="squadId")]
        SquadId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="type")]
        Type,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflowId")]
        WorkflowId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateBarInsightFromCallTableDTOGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateBarInsightFromCallTableDTOGroupBy value)
        {
            return value switch
            {
                UpdateBarInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                UpdateBarInsightFromCallTableDTOGroupBy.AssistantId => "assistantId",
                UpdateBarInsightFromCallTableDTOGroupBy.CampaignId => "campaignId",
                UpdateBarInsightFromCallTableDTOGroupBy.CustomerNumber => "customerNumber",
                UpdateBarInsightFromCallTableDTOGroupBy.EndedReason => "endedReason",
                UpdateBarInsightFromCallTableDTOGroupBy.PhoneNumberId => "phoneNumberId",
                UpdateBarInsightFromCallTableDTOGroupBy.SquadId => "squadId",
                UpdateBarInsightFromCallTableDTOGroupBy.Type => "type",
                UpdateBarInsightFromCallTableDTOGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateBarInsightFromCallTableDTOGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => UpdateBarInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => UpdateBarInsightFromCallTableDTOGroupBy.AssistantId,
                "campaignId" => UpdateBarInsightFromCallTableDTOGroupBy.CampaignId,
                "customerNumber" => UpdateBarInsightFromCallTableDTOGroupBy.CustomerNumber,
                "endedReason" => UpdateBarInsightFromCallTableDTOGroupBy.EndedReason,
                "phoneNumberId" => UpdateBarInsightFromCallTableDTOGroupBy.PhoneNumberId,
                "squadId" => UpdateBarInsightFromCallTableDTOGroupBy.SquadId,
                "type" => UpdateBarInsightFromCallTableDTOGroupBy.Type,
                "workflowId" => UpdateBarInsightFromCallTableDTOGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}