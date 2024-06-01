//HintName: G.Models.ReactionContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reaction to use
    /// <br/>Example: heart
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReactionContent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="+1")]
        Plus1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="-1")]
        Minus1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="laugh")]
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="confused")]
        Confused,
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
    public static class ReactionContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactionContent value)
        {
            return value switch
            {
                ReactionContent.Plus1 => "+1",
                ReactionContent.Minus1 => "-1",
                ReactionContent.Laugh => "laugh",
                ReactionContent.Confused => "confused",
                ReactionContent.Heart => "heart",
                ReactionContent.Hooray => "hooray",
                ReactionContent.Rocket => "rocket",
                ReactionContent.Eyes => "eyes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionContent ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionContent.Plus1,
                "-1" => ReactionContent.Minus1,
                "laugh" => ReactionContent.Laugh,
                "confused" => ReactionContent.Confused,
                "heart" => ReactionContent.Heart,
                "hooray" => ReactionContent.Hooray,
                "rocket" => ReactionContent.Rocket,
                "eyes" => ReactionContent.Eyes,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}