//HintName: G.Models.AgreementV2BackfillJobStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `PENDING` - Pending<br/>
    /// * `QUEUED` - Queued<br/>
    /// * `RUNNING` - Running<br/>
    /// * `COMPLETED` - Completed<br/>
    /// * `FAILED` - Failed
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgreementV2BackfillJobStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COMPLETED")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PENDING")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QUEUED")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="RUNNING")]
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgreementV2BackfillJobStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgreementV2BackfillJobStatusEnum value)
        {
            return value switch
            {
                AgreementV2BackfillJobStatusEnum.Completed => "COMPLETED",
                AgreementV2BackfillJobStatusEnum.Failed => "FAILED",
                AgreementV2BackfillJobStatusEnum.Pending => "PENDING",
                AgreementV2BackfillJobStatusEnum.Queued => "QUEUED",
                AgreementV2BackfillJobStatusEnum.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgreementV2BackfillJobStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => AgreementV2BackfillJobStatusEnum.Completed,
                "FAILED" => AgreementV2BackfillJobStatusEnum.Failed,
                "PENDING" => AgreementV2BackfillJobStatusEnum.Pending,
                "QUEUED" => AgreementV2BackfillJobStatusEnum.Queued,
                "RUNNING" => AgreementV2BackfillJobStatusEnum.Running,
                _ => null,
            };
        }
    }
}