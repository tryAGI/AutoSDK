//HintName: G.Models.RankingOptionsRanker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The ranker to use for the file search.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RankingOptionsRanker
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default-2024-11-15")]
        Default20241115,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RankingOptionsRankerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RankingOptionsRanker value)
        {
            return value switch
            {
                RankingOptionsRanker.Auto => "auto",
                RankingOptionsRanker.Default20241115 => "default-2024-11-15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RankingOptionsRanker? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RankingOptionsRanker.Auto,
                "default-2024-11-15" => RankingOptionsRanker.Default20241115,
                _ => null,
            };
        }
    }
}