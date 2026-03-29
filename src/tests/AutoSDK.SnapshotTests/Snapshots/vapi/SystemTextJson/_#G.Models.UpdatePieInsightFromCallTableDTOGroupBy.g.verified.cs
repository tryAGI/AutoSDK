//HintName: G.Models.UpdatePieInsightFromCallTableDTOGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the group by column for the insight when table is `call`.<br/>
    /// These are the columns to group the results by.<br/>
    /// All results are grouped by the time range step by default.<br/>
    /// Example: [assistant_id]
    /// </summary>
    public enum UpdatePieInsightFromCallTableDTOGroupBy
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
    public static class UpdatePieInsightFromCallTableDTOGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePieInsightFromCallTableDTOGroupBy value)
        {
            return value switch
            {
                UpdatePieInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                UpdatePieInsightFromCallTableDTOGroupBy.AssistantId => "assistantId",
                UpdatePieInsightFromCallTableDTOGroupBy.CampaignId => "campaignId",
                UpdatePieInsightFromCallTableDTOGroupBy.CustomerNumber => "customerNumber",
                UpdatePieInsightFromCallTableDTOGroupBy.EndedReason => "endedReason",
                UpdatePieInsightFromCallTableDTOGroupBy.PhoneNumberId => "phoneNumberId",
                UpdatePieInsightFromCallTableDTOGroupBy.SquadId => "squadId",
                UpdatePieInsightFromCallTableDTOGroupBy.Type => "type",
                UpdatePieInsightFromCallTableDTOGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePieInsightFromCallTableDTOGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => UpdatePieInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => UpdatePieInsightFromCallTableDTOGroupBy.AssistantId,
                "campaignId" => UpdatePieInsightFromCallTableDTOGroupBy.CampaignId,
                "customerNumber" => UpdatePieInsightFromCallTableDTOGroupBy.CustomerNumber,
                "endedReason" => UpdatePieInsightFromCallTableDTOGroupBy.EndedReason,
                "phoneNumberId" => UpdatePieInsightFromCallTableDTOGroupBy.PhoneNumberId,
                "squadId" => UpdatePieInsightFromCallTableDTOGroupBy.SquadId,
                "type" => UpdatePieInsightFromCallTableDTOGroupBy.Type,
                "workflowId" => UpdatePieInsightFromCallTableDTOGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}