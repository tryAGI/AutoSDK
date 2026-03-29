//HintName: G.Models.ViewOptionsMonitorViewOptionsOptionsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ViewOptionsMonitorViewOptionsOptionsType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ViewOptionsMonitorViewOptionsOptionsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewOptionsMonitorViewOptionsOptionsType value)
        {
            return value switch
            {
                ViewOptionsMonitorViewOptionsOptionsType.Experiment => "experiment",
                ViewOptionsMonitorViewOptionsOptionsType.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewOptionsMonitorViewOptionsOptionsType? ToEnum(string value)
        {
            return value switch
            {
                "experiment" => ViewOptionsMonitorViewOptionsOptionsType.Experiment,
                "project" => ViewOptionsMonitorViewOptionsOptionsType.Project,
                _ => null,
            };
        }
    }
}