//HintName: G.Models.PushModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PushModelResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="retrieving manifest")]
        RetrievingManifest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="starting upload")]
        StartingUpload,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pushing manifest")]
        PushingManifest,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
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
                PushModelResponseStatus.RetrievingManifest => "retrieving manifest",
                PushModelResponseStatus.StartingUpload => "starting upload",
                PushModelResponseStatus.PushingManifest => "pushing manifest",
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
                "retrieving manifest" => PushModelResponseStatus.RetrievingManifest,
                "starting upload" => PushModelResponseStatus.StartingUpload,
                "pushing manifest" => PushModelResponseStatus.PushingManifest,
                "success" => PushModelResponseStatus.Success,
                _ => null,
            };
        }
    }
}