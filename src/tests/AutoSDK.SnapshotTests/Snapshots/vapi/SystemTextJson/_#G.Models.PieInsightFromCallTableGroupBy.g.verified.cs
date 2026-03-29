//HintName: G.Models.PieInsightFromCallTableGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the group by column for the insight when table is `call`.<br/>
    /// These are the columns to group the results by.<br/>
    /// All results are grouped by the time range step by default.<br/>
    /// Example: [assistant_id]
    /// </summary>
    public enum PieInsightFromCallTableGroupBy
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
    public static class PieInsightFromCallTableGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PieInsightFromCallTableGroupBy value)
        {
            return value switch
            {
                PieInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                PieInsightFromCallTableGroupBy.AssistantId => "assistantId",
                PieInsightFromCallTableGroupBy.CampaignId => "campaignId",
                PieInsightFromCallTableGroupBy.CustomerNumber => "customerNumber",
                PieInsightFromCallTableGroupBy.EndedReason => "endedReason",
                PieInsightFromCallTableGroupBy.PhoneNumberId => "phoneNumberId",
                PieInsightFromCallTableGroupBy.SquadId => "squadId",
                PieInsightFromCallTableGroupBy.Type => "type",
                PieInsightFromCallTableGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PieInsightFromCallTableGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => PieInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => PieInsightFromCallTableGroupBy.AssistantId,
                "campaignId" => PieInsightFromCallTableGroupBy.CampaignId,
                "customerNumber" => PieInsightFromCallTableGroupBy.CustomerNumber,
                "endedReason" => PieInsightFromCallTableGroupBy.EndedReason,
                "phoneNumberId" => PieInsightFromCallTableGroupBy.PhoneNumberId,
                "squadId" => PieInsightFromCallTableGroupBy.SquadId,
                "type" => PieInsightFromCallTableGroupBy.Type,
                "workflowId" => PieInsightFromCallTableGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}