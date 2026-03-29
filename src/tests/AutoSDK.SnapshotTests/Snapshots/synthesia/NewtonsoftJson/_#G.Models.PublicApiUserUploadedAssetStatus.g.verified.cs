//HintName: G.Models.PublicApiUserUploadedAssetStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PublicApiUserUploadedAssetStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="awaiting_upload")]
        AwaitingUpload,
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
        [global::System.Runtime.Serialization.EnumMember(Value="ready")]
        Ready,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicApiUserUploadedAssetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicApiUserUploadedAssetStatus value)
        {
            return value switch
            {
                PublicApiUserUploadedAssetStatus.AwaitingUpload => "awaiting_upload",
                PublicApiUserUploadedAssetStatus.Error => "error",
                PublicApiUserUploadedAssetStatus.Processing => "processing",
                PublicApiUserUploadedAssetStatus.Ready => "ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicApiUserUploadedAssetStatus? ToEnum(string value)
        {
            return value switch
            {
                "awaiting_upload" => PublicApiUserUploadedAssetStatus.AwaitingUpload,
                "error" => PublicApiUserUploadedAssetStatus.Error,
                "processing" => PublicApiUserUploadedAssetStatus.Processing,
                "ready" => PublicApiUserUploadedAssetStatus.Ready,
                _ => null,
            };
        }
    }
}