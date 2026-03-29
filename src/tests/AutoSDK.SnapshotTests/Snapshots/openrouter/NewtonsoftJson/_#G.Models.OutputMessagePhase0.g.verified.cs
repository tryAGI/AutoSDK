//HintName: G.Models.OutputMessagePhase0.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OutputMessagePhase0
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="commentary")]
        Commentary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OutputMessagePhase0Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OutputMessagePhase0 value)
        {
            return value switch
            {
                OutputMessagePhase0.Commentary => "commentary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OutputMessagePhase0? ToEnum(string value)
        {
            return value switch
            {
                "commentary" => OutputMessagePhase0.Commentary,
                _ => null,
            };
        }
    }
}