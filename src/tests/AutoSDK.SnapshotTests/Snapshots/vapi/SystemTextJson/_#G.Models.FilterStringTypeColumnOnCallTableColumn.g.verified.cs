//HintName: G.Models.FilterStringTypeColumnOnCallTableColumn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the column in the call table that will be filtered on.<br/>
    /// String Type columns are columns where the rows store data as a string.<br/>
    /// Must be a valid column for the selected table.<br/>
    /// Example: assistant_id
    /// </summary>
    public enum FilterStringTypeColumnOnCallTableColumn
    {
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
        ForwardedPhoneNumber,
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
        Status,
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
    public static class FilterStringTypeColumnOnCallTableColumnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FilterStringTypeColumnOnCallTableColumn value)
        {
            return value switch
            {
                FilterStringTypeColumnOnCallTableColumn.AssistantId => "assistantId",
                FilterStringTypeColumnOnCallTableColumn.CampaignId => "campaignId",
                FilterStringTypeColumnOnCallTableColumn.CustomerNumber => "customerNumber",
                FilterStringTypeColumnOnCallTableColumn.EndedReason => "endedReason",
                FilterStringTypeColumnOnCallTableColumn.ForwardedPhoneNumber => "forwardedPhoneNumber",
                FilterStringTypeColumnOnCallTableColumn.PhoneNumberId => "phoneNumberId",
                FilterStringTypeColumnOnCallTableColumn.SquadId => "squadId",
                FilterStringTypeColumnOnCallTableColumn.Status => "status",
                FilterStringTypeColumnOnCallTableColumn.Type => "type",
                FilterStringTypeColumnOnCallTableColumn.WorkflowId => "workflowId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FilterStringTypeColumnOnCallTableColumn? ToEnum(string value)
        {
            return value switch
            {
                "assistantId" => FilterStringTypeColumnOnCallTableColumn.AssistantId,
                "campaignId" => FilterStringTypeColumnOnCallTableColumn.CampaignId,
                "customerNumber" => FilterStringTypeColumnOnCallTableColumn.CustomerNumber,
                "endedReason" => FilterStringTypeColumnOnCallTableColumn.EndedReason,
                "forwardedPhoneNumber" => FilterStringTypeColumnOnCallTableColumn.ForwardedPhoneNumber,
                "phoneNumberId" => FilterStringTypeColumnOnCallTableColumn.PhoneNumberId,
                "squadId" => FilterStringTypeColumnOnCallTableColumn.SquadId,
                "status" => FilterStringTypeColumnOnCallTableColumn.Status,
                "type" => FilterStringTypeColumnOnCallTableColumn.Type,
                "workflowId" => FilterStringTypeColumnOnCallTableColumn.WorkflowId,
                _ => null,
            };
        }
    }
}