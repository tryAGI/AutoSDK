//HintName: G.Models.BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: inbound
    /// </summary>
    public enum BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection value)
        {
            return value switch
            {
                BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection.Inbound => "inbound",
                BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection.Inbound,
                "outbound" => BodyRegisterATwilioCallAndReturnTwiMLV1ConvaiTwilioRegisterCallPostDirection.Outbound,
                _ => null,
            };
        }
    }
}