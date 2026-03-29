//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ACTIVE")]
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3Status.Active => "ACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => GetConnectedAccountsByNanoidResponseStateVariant7ValVariant3Status.Active,
                _ => null,
            };
        }
    }
}