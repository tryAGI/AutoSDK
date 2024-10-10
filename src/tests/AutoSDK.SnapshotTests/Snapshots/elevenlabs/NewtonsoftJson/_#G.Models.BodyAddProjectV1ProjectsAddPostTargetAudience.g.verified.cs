//HintName: G.Models.BodyAddProjectV1ProjectsAddPostTargetAudience.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An optional target audience of the project.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyAddProjectV1ProjectsAddPostTargetAudience
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
    public static class BodyAddProjectV1ProjectsAddPostTargetAudienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAddProjectV1ProjectsAddPostTargetAudience value)
        {
            return value switch
            {
                BodyAddProjectV1ProjectsAddPostTargetAudience.Children => "children",
                BodyAddProjectV1ProjectsAddPostTargetAudience.YoungAdult => "young adult",
                BodyAddProjectV1ProjectsAddPostTargetAudience.Adult => "adult",
                BodyAddProjectV1ProjectsAddPostTargetAudience.AllAges => "all ages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAddProjectV1ProjectsAddPostTargetAudience? ToEnum(string value)
        {
            return value switch
            {
                "children" => BodyAddProjectV1ProjectsAddPostTargetAudience.Children,
                "young adult" => BodyAddProjectV1ProjectsAddPostTargetAudience.YoungAdult,
                "adult" => BodyAddProjectV1ProjectsAddPostTargetAudience.Adult,
                "all ages" => BodyAddProjectV1ProjectsAddPostTargetAudience.AllAges,
                _ => null,
            };
        }
    }
}