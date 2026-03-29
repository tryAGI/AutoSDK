//HintName: G.Models.PieInsightGroupBy.g.cs

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
    public enum PieInsightGroupBy
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
    public static class PieInsightGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PieInsightGroupBy value)
        {
            return value switch
            {
                PieInsightGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                PieInsightGroupBy.AssistantId => "assistantId",
                PieInsightGroupBy.CampaignId => "campaignId",
                PieInsightGroupBy.CustomerNumber => "customerNumber",
                PieInsightGroupBy.EndedReason => "endedReason",
                PieInsightGroupBy.PhoneNumberId => "phoneNumberId",
                PieInsightGroupBy.SquadId => "squadId",
                PieInsightGroupBy.Type => "type",
                PieInsightGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PieInsightGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => PieInsightGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => PieInsightGroupBy.AssistantId,
                "campaignId" => PieInsightGroupBy.CampaignId,
                "customerNumber" => PieInsightGroupBy.CustomerNumber,
                "endedReason" => PieInsightGroupBy.EndedReason,
                "phoneNumberId" => PieInsightGroupBy.PhoneNumberId,
                "squadId" => PieInsightGroupBy.SquadId,
                "type" => PieInsightGroupBy.Type,
                "workflowId" => PieInsightGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}