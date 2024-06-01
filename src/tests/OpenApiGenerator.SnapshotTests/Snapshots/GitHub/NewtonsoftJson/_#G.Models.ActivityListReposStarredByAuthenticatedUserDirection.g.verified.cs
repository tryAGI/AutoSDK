//HintName: G.Models.ActivityListReposStarredByAuthenticatedUserDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActivityListReposStarredByAuthenticatedUserDirection
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
    public static class ActivityListReposStarredByAuthenticatedUserDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityListReposStarredByAuthenticatedUserDirection value)
        {
            return value switch
            {
                ActivityListReposStarredByAuthenticatedUserDirection.Asc => "asc",
                ActivityListReposStarredByAuthenticatedUserDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityListReposStarredByAuthenticatedUserDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => ActivityListReposStarredByAuthenticatedUserDirection.Asc,
                "desc" => ActivityListReposStarredByAuthenticatedUserDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}