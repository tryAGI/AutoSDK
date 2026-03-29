//HintName: G.Models.DashboardPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DashboardPublicType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiments")]
        Experiments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="multi_project")]
        MultiProject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DashboardPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DashboardPublicType value)
        {
            return value switch
            {
                DashboardPublicType.Experiments => "experiments",
                DashboardPublicType.MultiProject => "multi_project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DashboardPublicType? ToEnum(string value)
        {
            return value switch
            {
                "experiments" => DashboardPublicType.Experiments,
                "multi_project" => DashboardPublicType.MultiProject,
                _ => null,
            };
        }
    }
}