//HintName: G.Models.InputBehavior.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls how the input is processed when the session is already running.<br/>
    /// - `steer`: Insert the message as soon as possible on the next iteration of the agent loop.<br/>
    /// - `follow_up`: Insert the message after the current agent loop finishes, as a follow-up turn.<br/>
    ///   Follow-up inputs are consumed one at a time: after each follow-up turn completes, the next<br/>
    ///   queued follow-up is processed. This ensures each follow-up gets a full agent loop iteration.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InputBehavior
    {
        /// <summary>
        /// Insert the message after the current agent loop finishes, as a follow-up turn.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="follow_up")]
        FollowUp,
        /// <summary>
        /// Insert the message as soon as possible on the next iteration of the agent loop.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="steer")]
        Steer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputBehavior value)
        {
            return value switch
            {
                InputBehavior.FollowUp => "follow_up",
                InputBehavior.Steer => "steer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputBehavior? ToEnum(string value)
        {
            return value switch
            {
                "follow_up" => InputBehavior.FollowUp,
                "steer" => InputBehavior.Steer,
                _ => null,
            };
        }
    }
}