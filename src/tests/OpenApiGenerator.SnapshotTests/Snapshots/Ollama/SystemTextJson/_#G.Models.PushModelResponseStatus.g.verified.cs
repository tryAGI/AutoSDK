//HintName: G.Models.PushModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status pushing the model.
    /// </summary>
    public enum PushModelResponseStatus
    {
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
        PushingManifest,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    public static class PushModelResponseStatusExtensions
    {
        public static string ToValueString(this PushModelResponseStatus value)
        {
            return value switch
            {
                PushModelResponseStatus.RetrievingManifest => "retrieving manifest",
                PushModelResponseStatus.StartingUpload => "starting upload",
                PushModelResponseStatus.PushingManifest => "pushing manifest",
                PushModelResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PushModelResponseStatus ToEnum(string value)
        {
            return value switch
            {
                "retrieving manifest" => PushModelResponseStatus.RetrievingManifest,
                "starting upload" => PushModelResponseStatus.StartingUpload,
                "pushing manifest" => PushModelResponseStatus.PushingManifest,
                "success" => PushModelResponseStatus.Success,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PushModelResponseStatus ToEnum(int value)
        {
            return value switch
            {
                0 => PushModelResponseStatus.RetrievingManifest,
                1 => PushModelResponseStatus.StartingUpload,
                2 => PushModelResponseStatus.PushingManifest,
                3 => PushModelResponseStatus.Success,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}