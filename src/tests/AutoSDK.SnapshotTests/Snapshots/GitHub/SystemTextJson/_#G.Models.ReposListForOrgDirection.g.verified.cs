//HintName: G.Models.ReposListForOrgDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReposListForOrgDirection
    {
        /// <summary>
        /// `asc` when using `full_name`, otherwise `desc`.
        /// </summary>
        Asc,
        /// <summary>
        /// `asc` when using `full_name`, otherwise `desc`.
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReposListForOrgDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReposListForOrgDirection value)
        {
            return value switch
            {
                ReposListForOrgDirection.Asc => "asc",
                ReposListForOrgDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReposListForOrgDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ReposListForOrgDirection.Asc,
                "desc" => ReposListForOrgDirection.Desc,
                _ => null,
            };
        }
    }
}