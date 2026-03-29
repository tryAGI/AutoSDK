//HintName: G.Models.CreateLineInsightFromCallTableDTOGroupBy.g.cs

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
    public enum CreateLineInsightFromCallTableDTOGroupBy
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
    public static class CreateLineInsightFromCallTableDTOGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLineInsightFromCallTableDTOGroupBy value)
        {
            return value switch
            {
                CreateLineInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID => "artifact.structuredOutputs[OutputID]",
                CreateLineInsightFromCallTableDTOGroupBy.AssistantId => "assistantId",
                CreateLineInsightFromCallTableDTOGroupBy.CampaignId => "campaignId",
                CreateLineInsightFromCallTableDTOGroupBy.CustomerNumber => "customerNumber",
                CreateLineInsightFromCallTableDTOGroupBy.EndedReason => "endedReason",
                CreateLineInsightFromCallTableDTOGroupBy.PhoneNumberId => "phoneNumberId",
                CreateLineInsightFromCallTableDTOGroupBy.SquadId => "squadId",
                CreateLineInsightFromCallTableDTOGroupBy.Type => "type",
                CreateLineInsightFromCallTableDTOGroupBy.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLineInsightFromCallTableDTOGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "artifact.structuredOutputs[OutputID]" => CreateLineInsightFromCallTableDTOGroupBy.ArtifactStructuredOutputsOutputID,
                "assistantId" => CreateLineInsightFromCallTableDTOGroupBy.AssistantId,
                "campaignId" => CreateLineInsightFromCallTableDTOGroupBy.CampaignId,
                "customerNumber" => CreateLineInsightFromCallTableDTOGroupBy.CustomerNumber,
                "endedReason" => CreateLineInsightFromCallTableDTOGroupBy.EndedReason,
                "phoneNumberId" => CreateLineInsightFromCallTableDTOGroupBy.PhoneNumberId,
                "squadId" => CreateLineInsightFromCallTableDTOGroupBy.SquadId,
                "type" => CreateLineInsightFromCallTableDTOGroupBy.Type,
                "workflowId" => CreateLineInsightFromCallTableDTOGroupBy.WorkflowId,
                _ => null,
            };
        }
    }
}