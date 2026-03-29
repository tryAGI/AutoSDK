//HintName: G.Models.SegmentationEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `none` - none<br/>
    /// * `time` - time<br/>
    /// * `user` - user<br/>
    /// * `project` - project<br/>
    /// * `matrix` - matrix<br/>
    /// * `project_matrix` - project_matrix
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SegmentationEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="matrix")]
        Matrix,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_matrix")]
        ProjectMatrix,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="time")]
        Time,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentationEnum value)
        {
            return value switch
            {
                SegmentationEnum.Matrix => "matrix",
                SegmentationEnum.None => "none",
                SegmentationEnum.Project => "project",
                SegmentationEnum.ProjectMatrix => "project_matrix",
                SegmentationEnum.Time => "time",
                SegmentationEnum.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentationEnum? ToEnum(string value)
        {
            return value switch
            {
                "matrix" => SegmentationEnum.Matrix,
                "none" => SegmentationEnum.None,
                "project" => SegmentationEnum.Project,
                "project_matrix" => SegmentationEnum.ProjectMatrix,
                "time" => SegmentationEnum.Time,
                "user" => SegmentationEnum.User,
                _ => null,
            };
        }
    }
}