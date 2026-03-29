//HintName: G.Models.CreatePieInsightFromCallTableDTOGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the group by column for the insight when table is `call`.<br/>
    /// These are the columns to group the results by.<br/>
    /// All results are grouped by the time range step by default.<br/>
    /// Example: [assistant_id]
    /// </summary>
    public enum CreatePieInsightFromCallTableDTOGroupBy
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
    public static class CreatePieInsightFromCallTableDTOGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePieInsightFromCallTableDTOGroupBy value)
        {
            return value switch
            {
                CreatePieInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                CreatePieInsightFromCallTableDTOGroupBy.AssistantId => "assistantId",
                CreatePieInsightFromCallTableDTOGroupBy.CampaignId => "campaignId",
                CreatePieInsightFromCallTableDTOGroupBy.CustomerNumber => "customerNumber",
                CreatePieInsightFromCallTableDTOGroupBy.EndedReason => "endedReason",
                CreatePieInsightFromCallTableDTOGroupBy.PhoneNumberId => "phoneNumberId",
                CreatePieInsightFromCallTableDTOGroupBy.SquadId => "squadId",
                CreatePieInsightFromCallTableDTOGroupBy.Type => "type",
                CreatePieInsightFromCallTableDTOGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePieInsightFromCallTableDTOGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => CreatePieInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => CreatePieInsightFromCallTableDTOGroupBy.AssistantId,
                "campaignId" => CreatePieInsightFromCallTableDTOGroupBy.CampaignId,
                "customerNumber" => CreatePieInsightFromCallTableDTOGroupBy.CustomerNumber,
                "endedReason" => CreatePieInsightFromCallTableDTOGroupBy.EndedReason,
                "phoneNumberId" => CreatePieInsightFromCallTableDTOGroupBy.PhoneNumberId,
                "squadId" => CreatePieInsightFromCallTableDTOGroupBy.SquadId,
                "type" => CreatePieInsightFromCallTableDTOGroupBy.Type,
                "workflowId" => CreatePieInsightFromCallTableDTOGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}