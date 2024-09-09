//HintName: G.Models.PullsListDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PullsListDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PullsListDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PullsListDirection value)
        {
            return value switch
            {
                PullsListDirection.Asc => "asc",
                PullsListDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PullsListDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => PullsListDirection.Asc,
                "desc" => PullsListDirection.Desc,
                _ => null,
            };
        }
    }
}