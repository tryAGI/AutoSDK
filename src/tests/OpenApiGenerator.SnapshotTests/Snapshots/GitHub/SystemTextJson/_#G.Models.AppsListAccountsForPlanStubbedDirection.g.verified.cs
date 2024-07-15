//HintName: G.Models.AppsListAccountsForPlanStubbedDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsListAccountsForPlanStubbedDirection
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
    public static class AppsListAccountsForPlanStubbedDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsListAccountsForPlanStubbedDirection value)
        {
            return value switch
            {
                AppsListAccountsForPlanStubbedDirection.Asc => "asc",
                AppsListAccountsForPlanStubbedDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsListAccountsForPlanStubbedDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => AppsListAccountsForPlanStubbedDirection.Asc,
                "desc" => AppsListAccountsForPlanStubbedDirection.Desc,
                _ => null,
            };
        }
    }
}