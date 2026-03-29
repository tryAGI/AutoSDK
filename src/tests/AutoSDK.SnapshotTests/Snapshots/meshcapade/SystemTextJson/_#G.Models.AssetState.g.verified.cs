//HintName: G.Models.AssetState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssetState
    {
        /// <summary>
        /// 
        /// </summary>
        AwaitingAfiInput,
        /// <summary>
        /// 
        /// </summary>
        AwaitingAfsInput,
        /// <summary>
        /// 
        /// </summary>
        AwaitingAfvInput,
        /// <summary>
        /// 
        /// </summary>
        AwaitingProcessing,
        /// <summary>
        /// 
        /// </summary>
        AwaitingUpload,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Empty,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
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