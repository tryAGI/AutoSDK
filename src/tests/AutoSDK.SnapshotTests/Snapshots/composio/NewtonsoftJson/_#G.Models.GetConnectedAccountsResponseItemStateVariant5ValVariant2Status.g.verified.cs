//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant5ValVariant2Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsResponseItemStateVariant5ValVariant2Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INITIATED")]
        Initiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant5ValVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant5ValVariant2Status value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant5ValVariant2Status.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant5ValVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIATED" => GetConnectedAccountsResponseItemStateVariant5ValVariant2Status.Initiated,
                _ => null,
            };
        }
    }
}