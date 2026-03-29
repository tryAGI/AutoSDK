//HintName: G.Models.DashboardPublicScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public enum DashboardPublicScope
    {
        /// <summary>
        /// 
        /// </summary>
        Insights,
        /// <summary>
        /// 
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DashboardPublicScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DashboardPublicScope value)
        {
            return value switch
            {
                DashboardPublicScope.Insights => "insights",
                DashboardPublicScope.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DashboardPublicScope? ToEnum(string value)
        {
            return value switch
            {
                "insights" => DashboardPublicScope.Insights,
                "workspace" => DashboardPublicScope.Workspace,
                _ => null,
            };
        }
    }
}