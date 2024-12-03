//HintName: G.Models.DependabotAlertDependencyScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The execution scope of the vulnerable dependency.<br/>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertDependencyScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="development")]
        Development,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="runtime")]
        Runtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotAlertDependencyScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertDependencyScope value)
        {
            return value switch
            {
                DependabotAlertDependencyScope.Development => "development",
                DependabotAlertDependencyScope.Runtime => "runtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertDependencyScope? ToEnum(string value)
        {
            return value switch
            {
                "development" => DependabotAlertDependencyScope.Development,
                "runtime" => DependabotAlertDependencyScope.Runtime,
                _ => null,
            };
        }
    }
}