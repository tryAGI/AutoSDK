//HintName: G.Models.ProjectExtendedResponseModelAspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectExtendedResponseModelAspectRatio
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
    public static class ProjectExtendedResponseModelAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelAspectRatio value)
        {
            return value switch
            {
                ProjectExtendedResponseModelAspectRatio.x16_9 => "16:9",
                ProjectExtendedResponseModelAspectRatio.x1_1 => "1:1",
                ProjectExtendedResponseModelAspectRatio.x4_5 => "4:5",
                ProjectExtendedResponseModelAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => ProjectExtendedResponseModelAspectRatio.x16_9,
                "1:1" => ProjectExtendedResponseModelAspectRatio.x1_1,
                "4:5" => ProjectExtendedResponseModelAspectRatio.x4_5,
                "9:16" => ProjectExtendedResponseModelAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}