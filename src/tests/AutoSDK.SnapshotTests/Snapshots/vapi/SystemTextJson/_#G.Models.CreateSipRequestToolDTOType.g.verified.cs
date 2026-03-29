//HintName: G.Models.CreateSipRequestToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "sipRequest" for SIP request tool.
    /// </summary>
    public enum CreateSipRequestToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        SipRequest,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSipRequestToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSipRequestToolDTOType value)
        {
            return value switch
            {
                CreateSipRequestToolDTOType.SipRequest => "sipRequest",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSipRequestToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "sipRequest" => CreateSipRequestToolDTOType.SipRequest,
                _ => null,
            };
        }
    }
}