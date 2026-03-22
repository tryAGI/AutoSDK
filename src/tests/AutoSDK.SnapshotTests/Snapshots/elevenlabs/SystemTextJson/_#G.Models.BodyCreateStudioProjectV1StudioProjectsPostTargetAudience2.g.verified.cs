//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2
    {
        /// <summary>
        /// 
        /// </summary>
        Adult,
        /// <summary>
        /// 
        /// </summary>
        AllAges,
        /// <summary>
        /// 
        /// </summary>
        Children,
        /// <summary>
        /// 
        /// </summary>
        YoungAdult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2 value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.Adult => "adult",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.AllAges => "all ages",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.Children => "children",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.YoungAdult => "young adult",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2? ToEnum(string value)
        {
            return value switch
            {
                "adult" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.Adult,
                "all ages" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.AllAges,
                "children" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.Children,
                "young adult" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.YoungAdult,
                _ => null,
            };
        }
    }
}