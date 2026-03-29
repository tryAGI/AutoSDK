//HintName: G.Models.CreateChargeRequestChainId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateChargeRequestChainId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1")]
        x1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="137")]
        x137,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="8453")]
        x8453,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateChargeRequestChainIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChargeRequestChainId value)
        {
            return value switch
            {
                CreateChargeRequestChainId.x1 => "1",
                CreateChargeRequestChainId.x137 => "137",
                CreateChargeRequestChainId.x8453 => "8453",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChargeRequestChainId? ToEnum(string value)
        {
            return value switch
            {
                "1" => CreateChargeRequestChainId.x1,
                "137" => CreateChargeRequestChainId.x137,
                "8453" => CreateChargeRequestChainId.x8453,
                _ => null,
            };
        }
    }
}