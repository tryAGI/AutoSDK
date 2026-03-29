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
    [global::System.Runtime.Serialization.DataContract]
    public enum CreatePieInsightFromCallTableDTOGroupBy
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