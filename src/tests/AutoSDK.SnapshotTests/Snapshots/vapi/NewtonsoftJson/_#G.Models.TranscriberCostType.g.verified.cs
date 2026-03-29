//HintName: G.Models.TranscriberCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of cost, always 'transcriber' for this class.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranscriberCostType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transcriber")]
        Transcriber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriberCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriberCostType value)
        {
            return value switch
            {
                TranscriberCostType.Transcriber => "transcriber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriberCostType? ToEnum(string value)
        {
            return value switch
            {
                "transcriber" => TranscriberCostType.Transcriber,
                _ => null,
            };
        }
    }
}