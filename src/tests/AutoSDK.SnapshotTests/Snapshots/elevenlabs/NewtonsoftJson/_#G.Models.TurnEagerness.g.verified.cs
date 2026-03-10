//HintName: G.Models.TurnEagerness.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Agent's eagerness to respond. Higher values make agent wait for higher turn probability.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TurnEagerness
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="patient")]
        Patient,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="normal")]
        Normal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eager")]
        Eager,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TurnEagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TurnEagerness value)
        {
            return value switch
            {
                TurnEagerness.Patient => "patient",
                TurnEagerness.Normal => "normal",
                TurnEagerness.Eager => "eager",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TurnEagerness? ToEnum(string value)
        {
            return value switch
            {
                "patient" => TurnEagerness.Patient,
                "normal" => TurnEagerness.Normal,
                "eager" => TurnEagerness.Eager,
                _ => null,
            };
        }
    }
}