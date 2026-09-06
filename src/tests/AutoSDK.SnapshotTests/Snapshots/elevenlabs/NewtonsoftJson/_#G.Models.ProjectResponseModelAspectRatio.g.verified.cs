//HintName: G.Models.ProjectResponseModelAspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectResponseModelAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="16:9")]
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1:1")]
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="4:5")]
        x4_5,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="9:16")]
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectResponseModelAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelAspectRatio value)
        {
            return value switch
            {
                ProjectResponseModelAspectRatio.x16_9 => "16:9",
                ProjectResponseModelAspectRatio.x1_1 => "1:1",
                ProjectResponseModelAspectRatio.x4_5 => "4:5",
                ProjectResponseModelAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseModelAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => ProjectResponseModelAspectRatio.x16_9,
                "1:1" => ProjectResponseModelAspectRatio.x1_1,
                "4:5" => ProjectResponseModelAspectRatio.x4_5,
                "9:16" => ProjectResponseModelAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}