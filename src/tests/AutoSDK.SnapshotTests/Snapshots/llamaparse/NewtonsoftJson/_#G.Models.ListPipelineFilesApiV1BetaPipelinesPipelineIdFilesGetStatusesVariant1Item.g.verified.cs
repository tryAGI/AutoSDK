//HintName: G.Models.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELLED")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="IN_PROGRESS")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NOT_STARTED")]
        NotStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SUCCESS")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item value)
        {
            return value switch
            {
                ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item.Cancelled => "CANCELLED",
                ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item.Error => "ERROR",
                ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item.InProgress => "IN_PROGRESS",
                ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item.NotStarted => "NOT_STARTED",
                ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item.Cancelled,
                "ERROR" => ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item.Error,
                "IN_PROGRESS" => ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item.InProgress,
                "NOT_STARTED" => ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item.NotStarted,
                "SUCCESS" => ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item.Success,
                _ => null,
            };
        }
    }
}