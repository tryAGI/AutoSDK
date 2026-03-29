//HintName: G.Models.FilterStringArrayTypeColumnOnCallTableColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the column in the call table that will be filtered on.<br/>
    /// String Array Type columns are the same as String Type columns, but provides the ability to filter on multiple values provided as an array.<br/>
    /// Must be a valid column for the selected table.<br/>
    /// Example: assistant_id
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FilterStringArrayTypeColumnOnCallTableColumn
    {
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
        [global::System.Runtime.Serialization.EnumMember(Value="forwardedPhoneNumber")]
        ForwardedPhoneNumber,
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
        [global::System.Runtime.Serialization.EnumMember(Value="status")]
        Status,
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
    public static class FilterStringArrayTypeColumnOnCallTableColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterStringArrayTypeColumnOnCallTableColumn value)
        {
            return value switch
            {
                FilterStringArrayTypeColumnOnCallTableColumn.AssistantId => "assistantId",
                FilterStringArrayTypeColumnOnCallTableColumn.CampaignId => "campaignId",
                FilterStringArrayTypeColumnOnCallTableColumn.CustomerNumber => "customerNumber",
                FilterStringArrayTypeColumnOnCallTableColumn.EndedReason => "endedReason",
                FilterStringArrayTypeColumnOnCallTableColumn.ForwardedPhoneNumber => "forwardedPhoneNumber",
                FilterStringArrayTypeColumnOnCallTableColumn.PhoneNumberId => "phoneNumberId",
                FilterStringArrayTypeColumnOnCallTableColumn.SquadId => "squadId",
                FilterStringArrayTypeColumnOnCallTableColumn.Status => "status",
                FilterStringArrayTypeColumnOnCallTableColumn.Type => "type",
                FilterStringArrayTypeColumnOnCallTableColumn.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterStringArrayTypeColumnOnCallTableColumn? ToEnum(string value)
        {
            return value switch
            {
                "assistantId" => FilterStringArrayTypeColumnOnCallTableColumn.AssistantId,
                "campaignId" => FilterStringArrayTypeColumnOnCallTableColumn.CampaignId,
                "customerNumber" => FilterStringArrayTypeColumnOnCallTableColumn.CustomerNumber,
                "endedReason" => FilterStringArrayTypeColumnOnCallTableColumn.EndedReason,
                "forwardedPhoneNumber" => FilterStringArrayTypeColumnOnCallTableColumn.ForwardedPhoneNumber,
                "phoneNumberId" => FilterStringArrayTypeColumnOnCallTableColumn.PhoneNumberId,
                "squadId" => FilterStringArrayTypeColumnOnCallTableColumn.SquadId,
                "status" => FilterStringArrayTypeColumnOnCallTableColumn.Status,
                "type" => FilterStringArrayTypeColumnOnCallTableColumn.Type,
                "workflowId" => FilterStringArrayTypeColumnOnCallTableColumn.WorkflowId,
                _ => null,
            };
        }
    }
}