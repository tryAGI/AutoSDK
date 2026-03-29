//HintName: G.Models.StateTransitionMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is a state transition.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StateTransitionMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="state_transition")]
        StateTransition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StateTransitionMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StateTransitionMessageRole value)
        {
            return value switch
            {
                StateTransitionMessageRole.StateTransition => "state_transition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StateTransitionMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "state_transition" => StateTransitionMessageRole.StateTransition,
                _ => null,
            };
        }
    }
}