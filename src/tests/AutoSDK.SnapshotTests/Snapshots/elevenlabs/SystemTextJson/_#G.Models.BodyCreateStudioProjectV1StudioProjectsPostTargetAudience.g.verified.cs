//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BodyCreateStudioProjectV1StudioProjectsPostTargetAudience
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
    public static class BodyCreateStudioProjectV1StudioProjectsPostTargetAudienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostTargetAudience value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.Adult => "adult",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.AllAges => "all ages",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.Children => "children",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.YoungAdult => "young adult",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateStudioProjectV1StudioProjectsPostTargetAudience? ToEnum(string value)
        {
            return value switch
            {
                "adult" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.Adult,
                "all ages" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.AllAges,
                "children" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.Children,
                "young adult" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.YoungAdult,
                _ => null,
            };
        }
    }
}