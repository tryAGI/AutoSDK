//HintName: G.Models.UpdateLineInsightFromCallTableDTOGroupBy.g.cs

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
    public enum UpdateLineInsightFromCallTableDTOGroupBy
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
    public static class UpdateLineInsightFromCallTableDTOGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateLineInsightFromCallTableDTOGroupBy value)
        {
            return value switch
            {
                UpdateLineInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                UpdateLineInsightFromCallTableDTOGroupBy.AssistantId => "assistantId",
                UpdateLineInsightFromCallTableDTOGroupBy.CampaignId => "campaignId",
                UpdateLineInsightFromCallTableDTOGroupBy.CustomerNumber => "customerNumber",
                UpdateLineInsightFromCallTableDTOGroupBy.EndedReason => "endedReason",
                UpdateLineInsightFromCallTableDTOGroupBy.PhoneNumberId => "phoneNumberId",
                UpdateLineInsightFromCallTableDTOGroupBy.SquadId => "squadId",
                UpdateLineInsightFromCallTableDTOGroupBy.Type => "type",
                UpdateLineInsightFromCallTableDTOGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateLineInsightFromCallTableDTOGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => UpdateLineInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => UpdateLineInsightFromCallTableDTOGroupBy.AssistantId,
                "campaignId" => UpdateLineInsightFromCallTableDTOGroupBy.CampaignId,
                "customerNumber" => UpdateLineInsightFromCallTableDTOGroupBy.CustomerNumber,
                "endedReason" => UpdateLineInsightFromCallTableDTOGroupBy.EndedReason,
                "phoneNumberId" => UpdateLineInsightFromCallTableDTOGroupBy.PhoneNumberId,
                "squadId" => UpdateLineInsightFromCallTableDTOGroupBy.SquadId,
                "type" => UpdateLineInsightFromCallTableDTOGroupBy.Type,
                "workflowId" => UpdateLineInsightFromCallTableDTOGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}