//HintName: G.Models.AcuvityScanParametersPiiCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AcuvityScanParametersPiiCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        AbaRoutingNumber,
        /// <summary>
        /// 
        /// </summary>
        Address,
        /// <summary>
        /// 
        /// </summary>
        BankAccount,
        /// <summary>
        /// 
        /// </summary>
        BitcoinWallet,
        /// <summary>
        /// 
        /// </summary>
        CreditCard,
        /// <summary>
        /// 
        /// </summary>
        DriverLicense,
        /// <summary>
        /// 
        /// </summary>
        EmailAddress,
        /// <summary>
        /// 
        /// </summary>
        ItinNumber,
        /// <summary>
        /// 
        /// </summary>
        Location,
        /// <summary>
        /// 
        /// </summary>
        MedicalLicense,
        /// <summary>
        /// 
        /// </summary>
        MoneyAmount,
        /// <summary>
        /// 
        /// </summary>
        PassportNumber,
        /// <summary>
        /// 
        /// </summary>
        Person,
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
    public static class AcuvityScanParametersPiiCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcuvityScanParametersPiiCategorie value)
        {
            return value switch
            {
                AcuvityScanParametersPiiCategorie.AbaRoutingNumber => "aba_routing_number",
                AcuvityScanParametersPiiCategorie.Address => "address",
                AcuvityScanParametersPiiCategorie.BankAccount => "bank_account",
                AcuvityScanParametersPiiCategorie.BitcoinWallet => "bitcoin_wallet",
                AcuvityScanParametersPiiCategorie.CreditCard => "credit_card",
                AcuvityScanParametersPiiCategorie.DriverLicense => "driver_license",
                AcuvityScanParametersPiiCategorie.EmailAddress => "email_address",
                AcuvityScanParametersPiiCategorie.ItinNumber => "itin_number",
                AcuvityScanParametersPiiCategorie.Location => "location",
                AcuvityScanParametersPiiCategorie.MedicalLicense => "medical_license",
                AcuvityScanParametersPiiCategorie.MoneyAmount => "money_amount",
                AcuvityScanParametersPiiCategorie.PassportNumber => "passport_number",
                AcuvityScanParametersPiiCategorie.Person => "person",
                AcuvityScanParametersPiiCategorie.PhoneNumber => "phone_number",
                AcuvityScanParametersPiiCategorie.Ssn => "ssn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcuvityScanParametersPiiCategorie? ToEnum(string value)
        {
            return value switch
            {
                "aba_routing_number" => AcuvityScanParametersPiiCategorie.AbaRoutingNumber,
                "address" => AcuvityScanParametersPiiCategorie.Address,
                "bank_account" => AcuvityScanParametersPiiCategorie.BankAccount,
                "bitcoin_wallet" => AcuvityScanParametersPiiCategorie.BitcoinWallet,
                "credit_card" => AcuvityScanParametersPiiCategorie.CreditCard,
                "driver_license" => AcuvityScanParametersPiiCategorie.DriverLicense,
                "email_address" => AcuvityScanParametersPiiCategorie.EmailAddress,
                "itin_number" => AcuvityScanParametersPiiCategorie.ItinNumber,
                "location" => AcuvityScanParametersPiiCategorie.Location,
                "medical_license" => AcuvityScanParametersPiiCategorie.MedicalLicense,
                "money_amount" => AcuvityScanParametersPiiCategorie.MoneyAmount,
                "passport_number" => AcuvityScanParametersPiiCategorie.PassportNumber,
                "person" => AcuvityScanParametersPiiCategorie.Person,
                "phone_number" => AcuvityScanParametersPiiCategorie.PhoneNumber,
                "ssn" => AcuvityScanParametersPiiCategorie.Ssn,
                _ => null,
            };
        }
    }
}