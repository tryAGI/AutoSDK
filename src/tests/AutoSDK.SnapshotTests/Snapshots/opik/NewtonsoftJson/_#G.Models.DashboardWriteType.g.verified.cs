//HintName: G.Models.DashboardWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DashboardWriteType
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
    public static class DashboardWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DashboardWriteType value)
        {
            return value switch
            {
                DashboardWriteType.Experiments => "experiments",
                DashboardWriteType.MultiProject => "multi_project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DashboardWriteType? ToEnum(string value)
        {
            return value switch
            {
                "experiments" => DashboardWriteType.Experiments,
                "multi_project" => DashboardWriteType.MultiProject,
                _ => null,
            };
        }
    }
}