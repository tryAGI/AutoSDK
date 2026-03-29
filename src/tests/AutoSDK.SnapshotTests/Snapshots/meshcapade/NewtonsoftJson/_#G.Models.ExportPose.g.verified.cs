//HintName: G.Models.ExportPose.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExportPose
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="a")]
        A,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="i")]
        I,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scan")]
        Scan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="t")]
        T,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportPoseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportPose value)
        {
            return value switch
            {
                ExportPose.A => "a",
                ExportPose.I => "i",
                ExportPose.Scan => "scan",
                ExportPose.T => "t",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportPose? ToEnum(string value)
        {
            return value switch
            {
                "a" => ExportPose.A,
                "i" => ExportPose.I,
                "scan" => ExportPose.Scan,
                "t" => ExportPose.T,
                _ => null,
            };
        }
    }
}