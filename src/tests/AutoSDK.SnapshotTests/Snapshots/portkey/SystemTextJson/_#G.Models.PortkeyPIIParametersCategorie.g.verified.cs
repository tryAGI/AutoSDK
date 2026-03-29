//HintName: G.Models.PortkeyPIIParametersCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PortkeyPIIParametersCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        CreditCard,
        /// <summary>
        /// 
        /// </summary>
        EmailAddress,
        /// <summary>
        /// 
        /// </summary>
        IpAddress,
        /// <summary>
        /// 
        /// </summary>
        LocationAddress,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        Ssn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PortkeyPIIParametersCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PortkeyPIIParametersCategorie value)
        {
            return value switch
            {
                PortkeyPIIParametersCategorie.CreditCard => "CREDIT_CARD",
                PortkeyPIIParametersCategorie.EmailAddress => "EMAIL_ADDRESS",
                PortkeyPIIParametersCategorie.IpAddress => "IP_ADDRESS",
                PortkeyPIIParametersCategorie.LocationAddress => "LOCATION_ADDRESS",
                PortkeyPIIParametersCategorie.Name => "NAME",
                PortkeyPIIParametersCategorie.PhoneNumber => "PHONE_NUMBER",
                PortkeyPIIParametersCategorie.Ssn => "SSN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PortkeyPIIParametersCategorie? ToEnum(string value)
        {
            return value switch
            {
                "CREDIT_CARD" => PortkeyPIIParametersCategorie.CreditCard,
                "EMAIL_ADDRESS" => PortkeyPIIParametersCategorie.EmailAddress,
                "IP_ADDRESS" => PortkeyPIIParametersCategorie.IpAddress,
                "LOCATION_ADDRESS" => PortkeyPIIParametersCategorie.LocationAddress,
                "NAME" => PortkeyPIIParametersCategorie.Name,
                "PHONE_NUMBER" => PortkeyPIIParametersCategorie.PhoneNumber,
                "SSN" => PortkeyPIIParametersCategorie.Ssn,
                _ => null,
            };
        }
    }
}