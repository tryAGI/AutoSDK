//HintName: G.Models.CreateStream1ResponseJsepType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The session description object describes the initial proposal in an offer/answer exchange.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateStream1ResponseJsepType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="offer")]
        Offer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateStream1ResponseJsepTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateStream1ResponseJsepType value)
        {
            return value switch
            {
                CreateStream1ResponseJsepType.Offer => "offer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateStream1ResponseJsepType? ToEnum(string value)
        {
            return value switch
            {
                "offer" => CreateStream1ResponseJsepType.Offer,
                _ => null,
            };
        }
    }
}