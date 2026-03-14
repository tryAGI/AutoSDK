//HintName: G.Models.ListSessionArtifactsOrderBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListSessionArtifactsOrderBy
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
    public static class ListSessionArtifactsOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListSessionArtifactsOrderBy value)
        {
            return value switch
            {
                ListSessionArtifactsOrderBy.Asc => "asc",
                ListSessionArtifactsOrderBy.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListSessionArtifactsOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListSessionArtifactsOrderBy.Asc,
                "desc" => ListSessionArtifactsOrderBy.Desc,
                _ => null,
            };
        }
    }
}