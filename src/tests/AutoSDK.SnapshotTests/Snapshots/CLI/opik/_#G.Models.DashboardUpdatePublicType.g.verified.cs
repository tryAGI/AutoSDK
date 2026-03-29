//HintName: G.Models.DashboardUpdatePublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DashboardUpdatePublicType
    {
        /// <summary>
        /// 
        /// </summary>
        Experiments,
        /// <summary>
        /// 
        /// </summary>
        MultiProject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DashboardUpdatePublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DashboardUpdatePublicType value)
        {
            return value switch
            {
                DashboardUpdatePublicType.Experiments => "experiments",
                DashboardUpdatePublicType.MultiProject => "multi_project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DashboardUpdatePublicType? ToEnum(string value)
        {
            return value switch
            {
                "experiments" => DashboardUpdatePublicType.Experiments,
                "multi_project" => DashboardUpdatePublicType.MultiProject,
                _ => null,
            };
        }
    }
}