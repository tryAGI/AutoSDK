//HintName: G.Models.ScrapeResponseDataChangeTrackingChangeStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The result of the comparison between the two page versions. 'new' means this page did not exist before, 'same' means content has not changed, 'changed' means content has changed, 'removed' means the page was removed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScrapeResponseDataChangeTrackingChangeStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="changed")]
        Changed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="new")]
        New,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="removed")]
        Removed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="same")]
        Same,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeResponseDataChangeTrackingChangeStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeResponseDataChangeTrackingChangeStatus value)
        {
            return value switch
            {
                ScrapeResponseDataChangeTrackingChangeStatus.Changed => "changed",
                ScrapeResponseDataChangeTrackingChangeStatus.New => "new",
                ScrapeResponseDataChangeTrackingChangeStatus.Removed => "removed",
                ScrapeResponseDataChangeTrackingChangeStatus.Same => "same",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeResponseDataChangeTrackingChangeStatus? ToEnum(string value)
        {
            return value switch
            {
                "changed" => ScrapeResponseDataChangeTrackingChangeStatus.Changed,
                "new" => ScrapeResponseDataChangeTrackingChangeStatus.New,
                "removed" => ScrapeResponseDataChangeTrackingChangeStatus.Removed,
                "same" => ScrapeResponseDataChangeTrackingChangeStatus.Same,
                _ => null,
            };
        }
    }
}