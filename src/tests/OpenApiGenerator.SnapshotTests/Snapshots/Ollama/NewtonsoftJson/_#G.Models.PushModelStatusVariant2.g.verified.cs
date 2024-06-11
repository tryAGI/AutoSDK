//HintName: G.Models.PushModelStatusVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PushModelStatusVariant2
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
    public static class PushModelStatusVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PushModelStatusVariant2 value)
        {
            return value switch
            {
                PushModelStatusVariant2.RetrievingManifest => "retrieving manifest",
                PushModelStatusVariant2.StartingUpload => "starting upload",
                PushModelStatusVariant2.PushingManifest => "pushing manifest",
                PushModelStatusVariant2.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PushModelStatusVariant2? ToEnum(string value)
        {
            return value switch
            {
                "retrieving manifest" => PushModelStatusVariant2.RetrievingManifest,
                "starting upload" => PushModelStatusVariant2.StartingUpload,
                "pushing manifest" => PushModelStatusVariant2.PushingManifest,
                "success" => PushModelStatusVariant2.Success,
                _ => null,
            };
        }
    }
}