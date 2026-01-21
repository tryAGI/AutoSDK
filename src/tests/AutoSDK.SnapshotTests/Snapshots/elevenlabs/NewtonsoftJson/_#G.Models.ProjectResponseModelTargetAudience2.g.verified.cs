//HintName: G.Models.ProjectResponseModelTargetAudience2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectResponseModelTargetAudience2
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
    public static class ProjectResponseModelTargetAudience2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectResponseModelTargetAudience2 value)
        {
            return value switch
            {
                ProjectResponseModelTargetAudience2.Children => "children",
                ProjectResponseModelTargetAudience2.YoungAdult => "young adult",
                ProjectResponseModelTargetAudience2.Adult => "adult",
                ProjectResponseModelTargetAudience2.AllAges => "all ages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectResponseModelTargetAudience2? ToEnum(string value)
        {
            return value switch
            {
                "children" => ProjectResponseModelTargetAudience2.Children,
                "young adult" => ProjectResponseModelTargetAudience2.YoungAdult,
                "adult" => ProjectResponseModelTargetAudience2.Adult,
                "all ages" => ProjectResponseModelTargetAudience2.AllAges,
                _ => null,
            };
        }
    }
}