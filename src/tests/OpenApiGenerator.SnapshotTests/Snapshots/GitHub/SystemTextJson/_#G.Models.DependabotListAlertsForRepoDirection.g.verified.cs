//HintName: G.Models.DependabotListAlertsForRepoDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum DependabotListAlertsForRepoDirection
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
    public static class DependabotListAlertsForRepoDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotListAlertsForRepoDirection value)
        {
            return value switch
            {
                DependabotListAlertsForRepoDirection.Asc => "asc",
                DependabotListAlertsForRepoDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotListAlertsForRepoDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => DependabotListAlertsForRepoDirection.Asc,
                "desc" => DependabotListAlertsForRepoDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}