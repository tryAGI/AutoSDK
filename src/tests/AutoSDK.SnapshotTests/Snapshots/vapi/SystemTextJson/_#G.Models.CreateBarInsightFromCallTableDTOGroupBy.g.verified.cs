//HintName: G.Models.CreateBarInsightFromCallTableDTOGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the group by column for the insight when table is `call`.<br/>
    /// These are the columns to group the results by.<br/>
    /// All results are grouped by the time range step by default.<br/>
    /// Example: [assistant_id]
    /// </summary>
    public enum CreateBarInsightFromCallTableDTOGroupBy
    {
        /// <summary>
        /// 
        /// </summary>
        ArtifactStructuredOutputsOutputID,
        /// <summary>
        /// 
        /// </summary>
        AssistantId,
        /// <summary>
        /// 
        /// </summary>
        CampaignId,
        /// <summary>
        /// 
        /// </summary>
        CustomerNumber,
        /// <summary>
        /// 
        /// </summary>
        EndedReason,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumberId,
        /// <summary>
        /// 
        /// </summary>
        SquadId,
        /// <summary>
        /// 
        /// </summary>
        Type,
        /// <summary>
        /// 
        /// </summary>
        WorkflowId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateBarInsightFromCallTableDTOGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBarInsightFromCallTableDTOGroupBy value)
        {
            return value switch
            {
                CreateBarInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                CreateBarInsightFromCallTableDTOGroupBy.AssistantId => "assistantId",
                CreateBarInsightFromCallTableDTOGroupBy.CampaignId => "campaignId",
                CreateBarInsightFromCallTableDTOGroupBy.CustomerNumber => "customerNumber",
                CreateBarInsightFromCallTableDTOGroupBy.EndedReason => "endedReason",
                CreateBarInsightFromCallTableDTOGroupBy.PhoneNumberId => "phoneNumberId",
                CreateBarInsightFromCallTableDTOGroupBy.SquadId => "squadId",
                CreateBarInsightFromCallTableDTOGroupBy.Type => "type",
                CreateBarInsightFromCallTableDTOGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBarInsightFromCallTableDTOGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => CreateBarInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => CreateBarInsightFromCallTableDTOGroupBy.AssistantId,
                "campaignId" => CreateBarInsightFromCallTableDTOGroupBy.CampaignId,
                "customerNumber" => CreateBarInsightFromCallTableDTOGroupBy.CustomerNumber,
                "endedReason" => CreateBarInsightFromCallTableDTOGroupBy.EndedReason,
                "phoneNumberId" => CreateBarInsightFromCallTableDTOGroupBy.PhoneNumberId,
                "squadId" => CreateBarInsightFromCallTableDTOGroupBy.SquadId,
                "type" => CreateBarInsightFromCallTableDTOGroupBy.Type,
                "workflowId" => CreateBarInsightFromCallTableDTOGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}