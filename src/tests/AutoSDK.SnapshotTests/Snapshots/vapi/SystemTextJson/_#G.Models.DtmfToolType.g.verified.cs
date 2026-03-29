//HintName: G.Models.DtmfToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "dtmf" for DTMF tool.
    /// </summary>
    public enum DtmfToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Dtmf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DtmfToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DtmfToolType value)
        {
            return value switch
            {
                DtmfToolType.Dtmf => "dtmf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DtmfToolType? ToEnum(string value)
        {
            return value switch
            {
                "dtmf" => DtmfToolType.Dtmf,
                _ => null,
            };
        }
    }
}