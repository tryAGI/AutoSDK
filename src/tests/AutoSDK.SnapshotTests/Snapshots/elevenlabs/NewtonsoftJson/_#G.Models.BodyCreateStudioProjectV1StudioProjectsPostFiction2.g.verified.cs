//HintName: G.Models.BodyCreateStudioProjectV1StudioProjectsPostFiction2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BodyCreateStudioProjectV1StudioProjectsPostFiction2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fiction")]
        Fiction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="non-fiction")]
        NonFiction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyCreateStudioProjectV1StudioProjectsPostFiction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyCreateStudioProjectV1StudioProjectsPostFiction2 value)
        {
            return value switch
            {
                BodyCreateStudioProjectV1StudioProjectsPostFiction2.Fiction => "fiction",
                BodyCreateStudioProjectV1StudioProjectsPostFiction2.NonFiction => "non-fiction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyCreateStudioProjectV1StudioProjectsPostFiction2? ToEnum(string value)
        {
            return value switch
            {
                "fiction" => BodyCreateStudioProjectV1StudioProjectsPostFiction2.Fiction,
                "non-fiction" => BodyCreateStudioProjectV1StudioProjectsPostFiction2.NonFiction,
                _ => null,
            };
        }
    }
}