//HintName: G.Models.BodyAddProjectV1ProjectsAddPostTargetAudience2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyAddProjectV1ProjectsAddPostTargetAudience2
    {
        /// <summary>
        /// 
        /// </summary>
        Children,
        /// <summary>
        /// 
        /// </summary>
        YoungAdult,
        /// <summary>
        /// 
        /// </summary>
        Adult,
        /// <summary>
        /// 
        /// </summary>
        AllAges,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyAddProjectV1ProjectsAddPostTargetAudience2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyAddProjectV1ProjectsAddPostTargetAudience2 value)
        {
            return value switch
            {
                BodyAddProjectV1ProjectsAddPostTargetAudience2.Children => "children",
                BodyAddProjectV1ProjectsAddPostTargetAudience2.YoungAdult => "young adult",
                BodyAddProjectV1ProjectsAddPostTargetAudience2.Adult => "adult",
                BodyAddProjectV1ProjectsAddPostTargetAudience2.AllAges => "all ages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyAddProjectV1ProjectsAddPostTargetAudience2? ToEnum(string value)
        {
            return value switch
            {
                "children" => BodyAddProjectV1ProjectsAddPostTargetAudience2.Children,
                "young adult" => BodyAddProjectV1ProjectsAddPostTargetAudience2.YoungAdult,
                "adult" => BodyAddProjectV1ProjectsAddPostTargetAudience2.Adult,
                "all ages" => BodyAddProjectV1ProjectsAddPostTargetAudience2.AllAges,
                _ => null,
            };
        }
    }
}