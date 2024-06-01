//HintName: G.Models.ReactionsListForReleaseContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReactionsListForReleaseContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="+1")]
        Plus1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="laugh")]
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heart")]
        Heart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hooray")]
        Hooray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rocket")]
        Rocket,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eyes")]
        Eyes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReactionsListForReleaseContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionsListForReleaseContent value)
        {
            return value switch
            {
                ReactionsListForReleaseContent.Plus1 => "+1",
                ReactionsListForReleaseContent.Laugh => "laugh",
                ReactionsListForReleaseContent.Heart => "heart",
                ReactionsListForReleaseContent.Hooray => "hooray",
                ReactionsListForReleaseContent.Rocket => "rocket",
                ReactionsListForReleaseContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionsListForReleaseContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionsListForReleaseContent.Plus1,
                "laugh" => ReactionsListForReleaseContent.Laugh,
                "heart" => ReactionsListForReleaseContent.Heart,
                "hooray" => ReactionsListForReleaseContent.Hooray,
                "rocket" => ReactionsListForReleaseContent.Rocket,
                "eyes" => ReactionsListForReleaseContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}