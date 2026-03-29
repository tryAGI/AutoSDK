//HintName: G.Models.TranscriptionControllerListV2Statu.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriptionControllerListV2Statu
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
    public static class TranscriptionControllerListV2StatuExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionControllerListV2Statu value)
        {
            return value switch
            {
                TranscriptionControllerListV2Statu.Done => "done",
                TranscriptionControllerListV2Statu.Error => "error",
                TranscriptionControllerListV2Statu.Processing => "processing",
                TranscriptionControllerListV2Statu.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionControllerListV2Statu? ToEnum(string value)
        {
            return value switch
            {
                "done" => TranscriptionControllerListV2Statu.Done,
                "error" => TranscriptionControllerListV2Statu.Error,
                "processing" => TranscriptionControllerListV2Statu.Processing,
                "queued" => TranscriptionControllerListV2Statu.Queued,
                _ => null,
            };
        }
    }
}