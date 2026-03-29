//HintName: G.Models.ExpressiveInferenceMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressiveInferenceMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="idle")]
        Idle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="talk")]
        Talk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpressiveInferenceModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveInferenceMode value)
        {
            return value switch
            {
                ExpressiveInferenceMode.Idle => "idle",
                ExpressiveInferenceMode.Talk => "talk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveInferenceMode? ToEnum(string value)
        {
            return value switch
            {
                "idle" => ExpressiveInferenceMode.Idle,
                "talk" => ExpressiveInferenceMode.Talk,
                _ => null,
            };
        }
    }
}