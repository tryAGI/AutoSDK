//HintName: G.Models.LineInsightFromCallTableGroupBy.g.cs

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
    public enum LineInsightFromCallTableGroupBy
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
    public static class LineInsightFromCallTableGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LineInsightFromCallTableGroupBy value)
        {
            return value switch
            {
                LineInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                LineInsightFromCallTableGroupBy.AssistantId => "assistantId",
                LineInsightFromCallTableGroupBy.CampaignId => "campaignId",
                LineInsightFromCallTableGroupBy.CustomerNumber => "customerNumber",
                LineInsightFromCallTableGroupBy.EndedReason => "endedReason",
                LineInsightFromCallTableGroupBy.PhoneNumberId => "phoneNumberId",
                LineInsightFromCallTableGroupBy.SquadId => "squadId",
                LineInsightFromCallTableGroupBy.Type => "type",
                LineInsightFromCallTableGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LineInsightFromCallTableGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => LineInsightFromCallTableGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => LineInsightFromCallTableGroupBy.AssistantId,
                "campaignId" => LineInsightFromCallTableGroupBy.CampaignId,
                "customerNumber" => LineInsightFromCallTableGroupBy.CustomerNumber,
                "endedReason" => LineInsightFromCallTableGroupBy.EndedReason,
                "phoneNumberId" => LineInsightFromCallTableGroupBy.PhoneNumberId,
                "squadId" => LineInsightFromCallTableGroupBy.SquadId,
                "type" => LineInsightFromCallTableGroupBy.Type,
                "workflowId" => LineInsightFromCallTableGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}