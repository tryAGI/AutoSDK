//HintName: G.Models.ProjectResponseModelTargetAudience.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectResponseModelTargetAudience
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="children")]
        Children,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="young adult")]
        YoungAdult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="adult")]
        Adult,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all ages")]
        AllAges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectResponseModelTargetAudienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelTargetAudience value)
        {
            return value switch
            {
                ProjectResponseModelTargetAudience.Children => "children",
                ProjectResponseModelTargetAudience.YoungAdult => "young adult",
                ProjectResponseModelTargetAudience.Adult => "adult",
                ProjectResponseModelTargetAudience.AllAges => "all ages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseModelTargetAudience? ToEnum(string value)
        {
            return value switch
            {
                "children" => ProjectResponseModelTargetAudience.Children,
                "young adult" => ProjectResponseModelTargetAudience.YoungAdult,
                "adult" => ProjectResponseModelTargetAudience.Adult,
                "all ages" => ProjectResponseModelTargetAudience.AllAges,
                _ => null,
            };
        }
    }
}