//HintName: G.Models.HistoryControllerGetListV1Statu.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HistoryControllerGetListV1Statu
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="done")]
        Done,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HistoryControllerGetListV1StatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HistoryControllerGetListV1Statu value)
        {
            return value switch
            {
                HistoryControllerGetListV1Statu.Done => "done",
                HistoryControllerGetListV1Statu.Error => "error",
                HistoryControllerGetListV1Statu.Processing => "processing",
                HistoryControllerGetListV1Statu.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HistoryControllerGetListV1Statu? ToEnum(string value)
        {
            return value switch
            {
                "done" => HistoryControllerGetListV1Statu.Done,
                "error" => HistoryControllerGetListV1Statu.Error,
                "processing" => HistoryControllerGetListV1Statu.Processing,
                "queued" => HistoryControllerGetListV1Statu.Queued,
                _ => null,
            };
        }
    }
}