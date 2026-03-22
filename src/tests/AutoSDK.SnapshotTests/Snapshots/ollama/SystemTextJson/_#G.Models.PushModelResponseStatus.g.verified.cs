//HintName: G.Models.PushModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PushModelResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        PushingManifest,
        /// <summary>
        /// 
        /// </summary>
        RetrievingManifest,
        /// <summary>
        /// 
        /// </summary>
        StartingUpload,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PushModelResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PushModelResponseStatus value)
        {
            return value switch
            {
                PushModelResponseStatus.PushingManifest => "pushing manifest",
                PushModelResponseStatus.RetrievingManifest => "retrieving manifest",
                PushModelResponseStatus.StartingUpload => "starting upload",
                PushModelResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PushModelResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "pushing manifest" => PushModelResponseStatus.PushingManifest,
                "retrieving manifest" => PushModelResponseStatus.RetrievingManifest,
                "starting upload" => PushModelResponseStatus.StartingUpload,
                "success" => PushModelResponseStatus.Success,
                _ => null,
            };
        }
    }
}