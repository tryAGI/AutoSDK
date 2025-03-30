//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An optional target audience of the Studio project.<br/>
    /// Example: adult
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreateStudioProjectV1StudioProjectsPostTargetAudience
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
    public static class BodyCreateStudioProjectV1StudioProjectsPostTargetAudienceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostTargetAudience value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.Children => "children",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.YoungAdult => "young adult",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.Adult => "adult",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.AllAges => "all ages",
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
                "children" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.Children,
                "young adult" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.YoungAdult,
                "adult" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.Adult,
                "all ages" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience.AllAges,
                _ => null,
            };
        }
    }
}