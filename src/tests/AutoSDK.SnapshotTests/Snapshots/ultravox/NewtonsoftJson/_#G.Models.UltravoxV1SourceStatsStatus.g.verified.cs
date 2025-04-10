//HintName: G.Models.UltravoxV1SourceStatsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of this source, indicating whether it affects queries.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UltravoxV1SourceStatsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SOURCE_STATUS_UNSPECIFIED")]
        SOURCESTATUSUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SOURCE_STATUS_INITIALIZING")]
        SOURCESTATUSINITIALIZING,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SOURCE_STATUS_READY")]
        SOURCESTATUSREADY,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SOURCE_STATUS_UPDATING")]
        SOURCESTATUSUPDATING,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1SourceStatsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1SourceStatsStatus value)
        {
            return value switch
            {
                UltravoxV1SourceStatsStatus.SOURCESTATUSUNSPECIFIED => "SOURCE_STATUS_UNSPECIFIED",
                UltravoxV1SourceStatsStatus.SOURCESTATUSINITIALIZING => "SOURCE_STATUS_INITIALIZING",
                UltravoxV1SourceStatsStatus.SOURCESTATUSREADY => "SOURCE_STATUS_READY",
                UltravoxV1SourceStatsStatus.SOURCESTATUSUPDATING => "SOURCE_STATUS_UPDATING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1SourceStatsStatus? ToEnum(string value)
        {
            return value switch
            {
                "SOURCE_STATUS_UNSPECIFIED" => UltravoxV1SourceStatsStatus.SOURCESTATUSUNSPECIFIED,
                "SOURCE_STATUS_INITIALIZING" => UltravoxV1SourceStatsStatus.SOURCESTATUSINITIALIZING,
                "SOURCE_STATUS_READY" => UltravoxV1SourceStatsStatus.SOURCESTATUSREADY,
                "SOURCE_STATUS_UPDATING" => UltravoxV1SourceStatsStatus.SOURCESTATUSUPDATING,
                _ => null,
            };
        }
    }
}