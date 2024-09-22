//HintName: G.Models.DependabotAlertWithRepositoryDependencyScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The execution scope of the vulnerable dependency.<br/>
    /// Included only in responses
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertWithRepositoryDependencyScope
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
    public static class DependabotAlertWithRepositoryDependencyScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertWithRepositoryDependencyScope value)
        {
            return value switch
            {
                DependabotAlertWithRepositoryDependencyScope.Development => "development",
                DependabotAlertWithRepositoryDependencyScope.Runtime => "runtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertWithRepositoryDependencyScope? ToEnum(string value)
        {
            return value switch
            {
                "development" => DependabotAlertWithRepositoryDependencyScope.Development,
                "runtime" => DependabotAlertWithRepositoryDependencyScope.Runtime,
                _ => null,
            };
        }
    }
}