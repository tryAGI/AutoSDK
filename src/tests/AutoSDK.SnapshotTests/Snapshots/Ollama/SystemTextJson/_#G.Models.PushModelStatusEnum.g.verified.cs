//HintName: G.Models.PushModelStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PushModelStatusEnum
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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PushModelStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PushModelStatusEnum value)
        {
            return value switch
            {
                PushModelStatusEnum.RetrievingManifest => "retrieving manifest",
                PushModelStatusEnum.StartingUpload => "starting upload",
                PushModelStatusEnum.PushingManifest => "pushing manifest",
                PushModelStatusEnum.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PushModelStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "retrieving manifest" => PushModelStatusEnum.RetrievingManifest,
                "starting upload" => PushModelStatusEnum.StartingUpload,
                "pushing manifest" => PushModelStatusEnum.PushingManifest,
                "success" => PushModelStatusEnum.Success,
                _ => null,
            };
        }
    }
}