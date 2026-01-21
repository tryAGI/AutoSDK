//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2
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
    public static class BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2 value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.Children => "children",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.YoungAdult => "young adult",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.Adult => "adult",
                BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.AllAges => "all ages",
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
                "children" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.Children,
                "young adult" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.YoungAdult,
                "adult" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.Adult,
                "all ages" => BodyCreateStudioProjectV1StudioProjectsPostTargetAudience2.AllAges,
                _ => null,
            };
        }
    }
}