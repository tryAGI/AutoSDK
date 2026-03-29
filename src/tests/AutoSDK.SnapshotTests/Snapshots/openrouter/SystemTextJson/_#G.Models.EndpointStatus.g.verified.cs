//HintName: G.Models.EndpointStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndpointStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Minus1,
        /// <summary>
        /// 
        /// </summary>
        Minus10,
        /// <summary>
        /// 
        /// </summary>
        Minus2,
        /// <summary>
        /// 
        /// </summary>
        Minus3,
        /// <summary>
        /// 
        /// </summary>
        Minus5,
        /// <summary>
        /// 
        /// </summary>
        x0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndpointStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndpointStatus value)
        {
            return value switch
            {
                EndpointStatus.Minus1 => "-1",
                EndpointStatus.Minus10 => "-10",
                EndpointStatus.Minus2 => "-2",
                EndpointStatus.Minus3 => "-3",
                EndpointStatus.Minus5 => "-5",
                EndpointStatus.x0 => "0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndpointStatus? ToEnum(string value)
        {
            return value switch
            {
                "-1" => EndpointStatus.Minus1,
                "-10" => EndpointStatus.Minus10,
                "-2" => EndpointStatus.Minus2,
                "-3" => EndpointStatus.Minus3,
                "-5" => EndpointStatus.Minus5,
                "0" => EndpointStatus.x0,
                _ => null,
            };
        }
    }
}