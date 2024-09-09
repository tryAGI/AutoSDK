//HintName: G.Models.DependabotAlertWithRepositoryState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the Dependabot alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertWithRepositoryState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto_dismissed")]
        AutoDismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dismissed")]
        Dismissed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fixed")]
        Fixed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotAlertWithRepositoryStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertWithRepositoryState value)
        {
            return value switch
            {
                DependabotAlertWithRepositoryState.AutoDismissed => "auto_dismissed",
                DependabotAlertWithRepositoryState.Dismissed => "dismissed",
                DependabotAlertWithRepositoryState.Fixed => "fixed",
                DependabotAlertWithRepositoryState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertWithRepositoryState? ToEnum(string value)
        {
            return value switch
            {
                "auto_dismissed" => DependabotAlertWithRepositoryState.AutoDismissed,
                "dismissed" => DependabotAlertWithRepositoryState.Dismissed,
                "fixed" => DependabotAlertWithRepositoryState.Fixed,
                "open" => DependabotAlertWithRepositoryState.Open,
                _ => null,
            };
        }
    }
}