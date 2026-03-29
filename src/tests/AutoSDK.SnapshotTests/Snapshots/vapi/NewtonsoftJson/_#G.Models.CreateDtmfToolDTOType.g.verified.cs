//HintName: G.Models.CreateDtmfToolDTOType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool. "dtmf" for DTMF tool.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateDtmfToolDTOType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dtmf")]
        Dtmf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDtmfToolDTOTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDtmfToolDTOType value)
        {
            return value switch
            {
                CreateDtmfToolDTOType.Dtmf => "dtmf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDtmfToolDTOType? ToEnum(string value)
        {
            return value switch
            {
                "dtmf" => CreateDtmfToolDTOType.Dtmf,
                _ => null,
            };
        }
    }
}