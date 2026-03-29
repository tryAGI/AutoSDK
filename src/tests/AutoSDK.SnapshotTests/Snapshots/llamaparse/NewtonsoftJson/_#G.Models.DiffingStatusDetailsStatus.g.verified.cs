//HintName: G.Models.DiffingStatusDetailsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the diffing process<br/>
    /// Default Value: pending
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DiffingStatusDetailsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DiffingStatusDetailsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DiffingStatusDetailsStatus value)
        {
            return value switch
            {
                DiffingStatusDetailsStatus.Completed => "completed",
                DiffingStatusDetailsStatus.Failed => "failed",
                DiffingStatusDetailsStatus.Pending => "pending",
                DiffingStatusDetailsStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DiffingStatusDetailsStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => DiffingStatusDetailsStatus.Completed,
                "failed" => DiffingStatusDetailsStatus.Failed,
                "pending" => DiffingStatusDetailsStatus.Pending,
                "processing" => DiffingStatusDetailsStatus.Processing,
                _ => null,
            };
        }
    }
}