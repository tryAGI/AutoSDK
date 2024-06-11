//HintName: G.Models.PushModelStatusVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PushModelStatusVariant1
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
    public static class PushModelStatusVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PushModelStatusVariant1 value)
        {
            return value switch
            {
                PushModelStatusVariant1.RetrievingManifest => "retrieving manifest",
                PushModelStatusVariant1.StartingUpload => "starting upload",
                PushModelStatusVariant1.PushingManifest => "pushing manifest",
                PushModelStatusVariant1.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PushModelStatusVariant1? ToEnum(string value)
        {
            return value switch
            {
                "retrieving manifest" => PushModelStatusVariant1.RetrievingManifest,
                "starting upload" => PushModelStatusVariant1.StartingUpload,
                "pushing manifest" => PushModelStatusVariant1.PushingManifest,
                "success" => PushModelStatusVariant1.Success,
                _ => null,
            };
        }
    }
}