//HintName: G.Models.BarInsightFromCallTableGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the group by column for the insight when table is `call`.<br/>
    /// These are the columns to group the results by.<br/>
    /// All results are grouped by the time range step by default.<br/>
    /// Example: [assistant_id]
    /// </summary>
    public enum BarInsightFromCallTableGroupBy
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
    public static class BarInsightFromCallTableGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BarInsightFromCallTableGroupBy value)
        {
            return value switch
            {
                BarInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                BarInsightFromCallTableGroupBy.AssistantId => "assistantId",
                BarInsightFromCallTableGroupBy.CampaignId => "campaignId",
                BarInsightFromCallTableGroupBy.CustomerNumber => "customerNumber",
                BarInsightFromCallTableGroupBy.EndedReason => "endedReason",
                BarInsightFromCallTableGroupBy.PhoneNumberId => "phoneNumberId",
                BarInsightFromCallTableGroupBy.SquadId => "squadId",
                BarInsightFromCallTableGroupBy.Type => "type",
                BarInsightFromCallTableGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BarInsightFromCallTableGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => BarInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => BarInsightFromCallTableGroupBy.AssistantId,
                "campaignId" => BarInsightFromCallTableGroupBy.CampaignId,
                "customerNumber" => BarInsightFromCallTableGroupBy.CustomerNumber,
                "endedReason" => BarInsightFromCallTableGroupBy.EndedReason,
                "phoneNumberId" => BarInsightFromCallTableGroupBy.PhoneNumberId,
                "squadId" => BarInsightFromCallTableGroupBy.SquadId,
                "type" => BarInsightFromCallTableGroupBy.Type,
                "workflowId" => BarInsightFromCallTableGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}