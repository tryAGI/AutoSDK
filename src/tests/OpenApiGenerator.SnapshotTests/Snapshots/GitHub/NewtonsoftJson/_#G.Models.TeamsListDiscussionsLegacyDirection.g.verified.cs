//HintName: G.Models.TeamsListDiscussionsLegacyDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TeamsListDiscussionsLegacyDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TeamsListDiscussionsLegacyDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TeamsListDiscussionsLegacyDirection value)
        {
            return value switch
            {
                TeamsListDiscussionsLegacyDirection.Asc => "asc",
                TeamsListDiscussionsLegacyDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TeamsListDiscussionsLegacyDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => TeamsListDiscussionsLegacyDirection.Asc,
                "desc" => TeamsListDiscussionsLegacyDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}