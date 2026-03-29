//HintName: G.Models.ValueEntryExperimentItemBulkWriteViewSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ValueEntryExperimentItemBulkWriteViewSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="online_scoring")]
        OnlineScoring,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sdk")]
        Sdk,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ui")]
        Ui,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValueEntryExperimentItemBulkWriteViewSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValueEntryExperimentItemBulkWriteViewSource value)
        {
            return value switch
            {
                ValueEntryExperimentItemBulkWriteViewSource.OnlineScoring => "online_scoring",
                ValueEntryExperimentItemBulkWriteViewSource.Sdk => "sdk",
                ValueEntryExperimentItemBulkWriteViewSource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValueEntryExperimentItemBulkWriteViewSource? ToEnum(string value)
        {
            return value switch
            {
                "online_scoring" => ValueEntryExperimentItemBulkWriteViewSource.OnlineScoring,
                "sdk" => ValueEntryExperimentItemBulkWriteViewSource.Sdk,
                "ui" => ValueEntryExperimentItemBulkWriteViewSource.Ui,
                _ => null,
            };
        }
    }
}