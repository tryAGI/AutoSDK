//HintName: G.Models.CreateSmsToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "sms" for Twilio SMS sending tool.
    /// </summary>
    public enum CreateSmsToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSmsToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSmsToolDTOType value)
        {
            return value switch
            {
                CreateSmsToolDTOType.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSmsToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "sms" => CreateSmsToolDTOType.Sms,
                _ => null,
            };
        }
    }
}