//HintName: G.Models.BarInsightGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the group by column for the insight when table is `call`.<br/>
    /// These are the columns to group the results by.<br/>
    /// All results are grouped by the time range step by default.<br/>
    /// Example: [assistant_id]
    /// </summary>
    public enum BarInsightGroupBy
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
    public static class BarInsightGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BarInsightGroupBy value)
        {
            return value switch
            {
                BarInsightGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                BarInsightGroupBy.AssistantId => "assistantId",
                BarInsightGroupBy.CampaignId => "campaignId",
                BarInsightGroupBy.CustomerNumber => "customerNumber",
                BarInsightGroupBy.EndedReason => "endedReason",
                BarInsightGroupBy.PhoneNumberId => "phoneNumberId",
                BarInsightGroupBy.SquadId => "squadId",
                BarInsightGroupBy.Type => "type",
                BarInsightGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BarInsightGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => BarInsightGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => BarInsightGroupBy.AssistantId,
                "campaignId" => BarInsightGroupBy.CampaignId,
                "customerNumber" => BarInsightGroupBy.CustomerNumber,
                "endedReason" => BarInsightGroupBy.EndedReason,
                "phoneNumberId" => BarInsightGroupBy.PhoneNumberId,
                "squadId" => BarInsightGroupBy.SquadId,
                "type" => BarInsightGroupBy.Type,
                "workflowId" => BarInsightGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}