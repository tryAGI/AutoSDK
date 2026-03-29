//HintName: G.Models.CallHookModelResponseTimeoutOn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the event that triggers this hook
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallHookModelResponseTimeoutOn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model.response.timeout")]
        ModelResponseTimeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallHookModelResponseTimeoutOnExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallHookModelResponseTimeoutOn value)
        {
            return value switch
            {
                CallHookModelResponseTimeoutOn.ModelResponseTimeout => "model.response.timeout",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallHookModelResponseTimeoutOn? ToEnum(string value)
        {
            return value switch
            {
                "model.response.timeout" => CallHookModelResponseTimeoutOn.ModelResponseTimeout,
                _ => null,
            };
        }
    }
}