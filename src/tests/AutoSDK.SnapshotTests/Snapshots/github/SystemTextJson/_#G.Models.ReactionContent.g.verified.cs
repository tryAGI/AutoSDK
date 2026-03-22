//HintName: G.Models.ReactionContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reaction to use<br/>
    /// Example: heart
    /// </summary>
    public enum ReactionContent
    {
        /// <summary>
        /// 
        /// </summary>
        Plus1,
        /// <summary>
        /// 
        /// </summary>
        Minus1,
        /// <summary>
        /// 
        /// </summary>
        Confused,
        /// <summary>
        /// 
        /// </summary>
        Eyes,
        /// <summary>
        /// 
        /// </summary>
        Heart,
        /// <summary>
        /// 
        /// </summary>
        Hooray,
        /// <summary>
        /// 
        /// </summary>
        Laugh,
        /// <summary>
        /// 
        /// </summary>
        Rocket,
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
                ReactionContent.Confused => "confused",
                ReactionContent.Eyes => "eyes",
                ReactionContent.Heart => "heart",
                ReactionContent.Hooray => "hooray",
                ReactionContent.Laugh => "laugh",
                ReactionContent.Rocket => "rocket",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactionContent? ToEnum(string value)
        {
            return value switch
            {
                "+1" => ReactionContent.Plus1,
                "-1" => ReactionContent.Minus1,
                "confused" => ReactionContent.Confused,
                "eyes" => ReactionContent.Eyes,
                "heart" => ReactionContent.Heart,
                "hooray" => ReactionContent.Hooray,
                "laugh" => ReactionContent.Laugh,
                "rocket" => ReactionContent.Rocket,
                _ => null,
            };
        }
    }
}