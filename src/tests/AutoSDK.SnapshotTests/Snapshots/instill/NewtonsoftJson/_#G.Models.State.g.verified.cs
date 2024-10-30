//HintName: G.Models.State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State describes the state of a model. See [Deploy<br/>
    /// Models](https://www.instill.tech/docs/latest/model/deploy) for more<br/>
    /// information.<br/>
    ///  - STATE_OFFLINE: Offline is the state when the model instance number is 0.<br/>
    ///  - STATE_ACTIVE: Active is the state when a model is processing requests.<br/>
    ///  - STATE_IDLE: Idle is the state when a model is alive but not processing requests.<br/>
    ///  - STATE_ERROR: Error is the state when the model is undeployable.<br/>
    ///  - STATE_STARTING: Starting is the state when the system is provisioning the necessary<br/>
    /// resources for the model<br/>
    ///  - STATE_SCALING_UP: Scaling Up is the transition state when the system is provisioning compute resource for this model instance.<br/>
    ///  - STATE_SCALING_DOWN: Scaling is the transition state when the system is releasing compute resource for this model instance.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum State
    {
        /// <summary>
        /// Offline is the state when the model instance number is 0.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_OFFLINE")]
        OFFLINE,
        /// <summary>
        /// Active is the state when a model is processing requests.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_ACTIVE")]
        ACTIVE,
        /// <summary>
        /// Idle is the state when a model is alive but not processing requests.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_IDLE")]
        IDLE,
        /// <summary>
        /// Error is the state when the model is undeployable.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_ERROR")]
        ERROR,
        /// <summary>
        /// Starting is the state when the system is provisioning the necessary
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_STARTING")]
        STARTING,
        /// <summary>
        /// Scaling Up is the transition state when the system is provisioning compute resource for this model instance.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_SCALING_UP")]
        SCALINGUP,
        /// <summary>
        /// Scaling is the transition state when the system is releasing compute resource for this model instance.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="STATE_SCALING_DOWN")]
        SCALINGDOWN,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this State value)
        {
            return value switch
            {
                State.OFFLINE => "STATE_OFFLINE",
                State.ACTIVE => "STATE_ACTIVE",
                State.IDLE => "STATE_IDLE",
                State.ERROR => "STATE_ERROR",
                State.STARTING => "STATE_STARTING",
                State.SCALINGUP => "STATE_SCALING_UP",
                State.SCALINGDOWN => "STATE_SCALING_DOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static State? ToEnum(string value)
        {
            return value switch
            {
                "STATE_OFFLINE" => State.OFFLINE,
                "STATE_ACTIVE" => State.ACTIVE,
                "STATE_IDLE" => State.IDLE,
                "STATE_ERROR" => State.ERROR,
                "STATE_STARTING" => State.STARTING,
                "STATE_SCALING_UP" => State.SCALINGUP,
                "STATE_SCALING_DOWN" => State.SCALINGDOWN,
                _ => null,
            };
        }
    }
}