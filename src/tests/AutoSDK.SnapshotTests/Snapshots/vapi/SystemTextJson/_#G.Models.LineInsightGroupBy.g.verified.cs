//HintName: G.Models.LineInsightGroupBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the group by column for the insight when table is `call`.<br/>
    /// These are the columns to group the results by.<br/>
    /// All results are grouped by the time range step by default.<br/>
    /// Example: [assistant_id]
    /// </summary>
    public enum LineInsightGroupBy
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
    public static class LineInsightGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LineInsightGroupBy value)
        {
            return value switch
            {
                LineInsightGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                LineInsightGroupBy.AssistantId => "assistantId",
                LineInsightGroupBy.CampaignId => "campaignId",
                LineInsightGroupBy.CustomerNumber => "customerNumber",
                LineInsightGroupBy.EndedReason => "endedReason",
                LineInsightGroupBy.PhoneNumberId => "phoneNumberId",
                LineInsightGroupBy.SquadId => "squadId",
                LineInsightGroupBy.Type => "type",
                LineInsightGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LineInsightGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => LineInsightGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => LineInsightGroupBy.AssistantId,
                "campaignId" => LineInsightGroupBy.CampaignId,
                "customerNumber" => LineInsightGroupBy.CustomerNumber,
                "endedReason" => LineInsightGroupBy.EndedReason,
                "phoneNumberId" => LineInsightGroupBy.PhoneNumberId,
                "squadId" => LineInsightGroupBy.SquadId,
                "type" => LineInsightGroupBy.Type,
                "workflowId" => LineInsightGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}