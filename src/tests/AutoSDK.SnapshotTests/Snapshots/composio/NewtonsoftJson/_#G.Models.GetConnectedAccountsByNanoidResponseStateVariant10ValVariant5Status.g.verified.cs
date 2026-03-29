//HintName: G.Models.GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FAILED")]
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5Status.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5Status? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => GetConnectedAccountsByNanoidResponseStateVariant10ValVariant5Status.Failed,
                _ => null,
            };
        }
    }
}