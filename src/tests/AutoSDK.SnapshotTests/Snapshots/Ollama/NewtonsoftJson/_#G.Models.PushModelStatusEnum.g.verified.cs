//HintName: G.Models.PushModelStatusEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PushModelStatusEnum
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