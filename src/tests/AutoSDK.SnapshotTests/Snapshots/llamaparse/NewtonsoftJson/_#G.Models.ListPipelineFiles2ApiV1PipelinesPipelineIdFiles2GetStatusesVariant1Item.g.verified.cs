//HintName: G.Models.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item
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
    public static class ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item value)
        {
            return value switch
            {
                ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item.Cancelled => "CANCELLED",
                ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item.Error => "ERROR",
                ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item.InProgress => "IN_PROGRESS",
                ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item.NotStarted => "NOT_STARTED",
                ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "CANCELLED" => ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item.Cancelled,
                "ERROR" => ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item.Error,
                "IN_PROGRESS" => ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item.InProgress,
                "NOT_STARTED" => ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item.NotStarted,
                "SUCCESS" => ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item.Success,
                _ => null,
            };
        }
    }
}