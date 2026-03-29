//HintName: G.Models.AssetState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssetState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AWAITING_AFI_INPUT")]
        AwaitingAfiInput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AWAITING_AFS_INPUT")]
        AwaitingAfsInput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AWAITING_AFV_INPUT")]
        AwaitingAfvInput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AWAITING_PROCESSING")]
        AwaitingProcessing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AWAITING_UPLOAD")]
        AwaitingUpload,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANCELED")]
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="EMPTY")]
        Empty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ERROR")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PROCESSING")]
        Processing,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="READY")]
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetState value)
        {
            return value switch
            {
                AssetState.AwaitingAfiInput => "AWAITING_AFI_INPUT",
                AssetState.AwaitingAfsInput => "AWAITING_AFS_INPUT",
                AssetState.AwaitingAfvInput => "AWAITING_AFV_INPUT",
                AssetState.AwaitingProcessing => "AWAITING_PROCESSING",
                AssetState.AwaitingUpload => "AWAITING_UPLOAD",
                AssetState.Canceled => "CANCELED",
                AssetState.Empty => "EMPTY",
                AssetState.Error => "ERROR",
                AssetState.Processing => "PROCESSING",
                AssetState.Ready => "READY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetState? ToEnum(string value)
        {
            return value switch
            {
                "AWAITING_AFI_INPUT" => AssetState.AwaitingAfiInput,
                "AWAITING_AFS_INPUT" => AssetState.AwaitingAfsInput,
                "AWAITING_AFV_INPUT" => AssetState.AwaitingAfvInput,
                "AWAITING_PROCESSING" => AssetState.AwaitingProcessing,
                "AWAITING_UPLOAD" => AssetState.AwaitingUpload,
                "CANCELED" => AssetState.Canceled,
                "EMPTY" => AssetState.Empty,
                "ERROR" => AssetState.Error,
                "PROCESSING" => AssetState.Processing,
                "READY" => AssetState.Ready,
                _ => null,
            };
        }
    }
}