//HintName: G.Models.DependabotAlertState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the Dependabot alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertState
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
    public static class DependabotAlertStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertState value)
        {
            return value switch
            {
                DependabotAlertState.AutoDismissed => "auto_dismissed",
                DependabotAlertState.Dismissed => "dismissed",
                DependabotAlertState.Fixed => "fixed",
                DependabotAlertState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertState ToEnum(string value)
        {
            return value switch
            {
                "auto_dismissed" => DependabotAlertState.AutoDismissed,
                "dismissed" => DependabotAlertState.Dismissed,
                "fixed" => DependabotAlertState.Fixed,
                "open" => DependabotAlertState.Open,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}