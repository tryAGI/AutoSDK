//HintName: G.Models.ListExportRequestsV2ResponseItemStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListExportRequestsV2ResponseItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="created")]
        Created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="processing")]
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListExportRequestsV2ResponseItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListExportRequestsV2ResponseItemStatus value)
        {
            return value switch
            {
                ListExportRequestsV2ResponseItemStatus.Completed => "completed",
                ListExportRequestsV2ResponseItemStatus.Created => "created",
                ListExportRequestsV2ResponseItemStatus.Error => "error",
                ListExportRequestsV2ResponseItemStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListExportRequestsV2ResponseItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ListExportRequestsV2ResponseItemStatus.Completed,
                "created" => ListExportRequestsV2ResponseItemStatus.Created,
                "error" => ListExportRequestsV2ResponseItemStatus.Error,
                "processing" => ListExportRequestsV2ResponseItemStatus.Processing,
                _ => null,
            };
        }
    }
}