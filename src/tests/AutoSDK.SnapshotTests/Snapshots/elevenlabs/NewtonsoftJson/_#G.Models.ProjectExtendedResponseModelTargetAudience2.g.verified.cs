//HintName: G.Models.ProjectExtendedResponseModelTargetAudience2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectExtendedResponseModelTargetAudience2
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
    public static class ProjectExtendedResponseModelTargetAudience2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelTargetAudience2 value)
        {
            return value switch
            {
                ProjectExtendedResponseModelTargetAudience2.Children => "children",
                ProjectExtendedResponseModelTargetAudience2.YoungAdult => "young adult",
                ProjectExtendedResponseModelTargetAudience2.Adult => "adult",
                ProjectExtendedResponseModelTargetAudience2.AllAges => "all ages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelTargetAudience2? ToEnum(string value)
        {
            return value switch
            {
                "children" => ProjectExtendedResponseModelTargetAudience2.Children,
                "young adult" => ProjectExtendedResponseModelTargetAudience2.YoungAdult,
                "adult" => ProjectExtendedResponseModelTargetAudience2.Adult,
                "all ages" => ProjectExtendedResponseModelTargetAudience2.AllAges,
                _ => null,
            };
        }
    }
}