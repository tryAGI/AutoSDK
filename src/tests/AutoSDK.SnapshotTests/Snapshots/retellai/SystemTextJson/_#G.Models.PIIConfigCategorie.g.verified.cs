//HintName: G.Models.PIIConfigCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PIIConfigCategorie
    {
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
        CreditCard,
        /// <summary>
        /// 
        /// </summary>
        CustomerAccountNumber,
        /// <summary>
        /// 
        /// </summary>
        DateOfBirth,
        /// <summary>
        /// 
        /// </summary>
        DriverLicense,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        MedicalId,
        /// <summary>
        /// 
        /// </summary>
        Passport,
        /// <summary>
        /// 
        /// </summary>
        Password,
        /// <summary>
        /// 
        /// </summary>
        PersonName,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        Pin,
        /// <summary>
        /// 
        /// </summary>
        Ssn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PIIConfigCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PIIConfigCategorie value)
        {
            return value switch
            {
                PIIConfigCategorie.Address => "address",
                PIIConfigCategorie.BankAccount => "bank_account",
                PIIConfigCategorie.CreditCard => "credit_card",
                PIIConfigCategorie.CustomerAccountNumber => "customer_account_number",
                PIIConfigCategorie.DateOfBirth => "date_of_birth",
                PIIConfigCategorie.DriverLicense => "driver_license",
                PIIConfigCategorie.Email => "email",
                PIIConfigCategorie.MedicalId => "medical_id",
                PIIConfigCategorie.Passport => "passport",
                PIIConfigCategorie.Password => "password",
                PIIConfigCategorie.PersonName => "person_name",
                PIIConfigCategorie.PhoneNumber => "phone_number",
                PIIConfigCategorie.Pin => "pin",
                PIIConfigCategorie.Ssn => "ssn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PIIConfigCategorie? ToEnum(string value)
        {
            return value switch
            {
                "address" => PIIConfigCategorie.Address,
                "bank_account" => PIIConfigCategorie.BankAccount,
                "credit_card" => PIIConfigCategorie.CreditCard,
                "customer_account_number" => PIIConfigCategorie.CustomerAccountNumber,
                "date_of_birth" => PIIConfigCategorie.DateOfBirth,
                "driver_license" => PIIConfigCategorie.DriverLicense,
                "email" => PIIConfigCategorie.Email,
                "medical_id" => PIIConfigCategorie.MedicalId,
                "passport" => PIIConfigCategorie.Passport,
                "password" => PIIConfigCategorie.Password,
                "person_name" => PIIConfigCategorie.PersonName,
                "phone_number" => PIIConfigCategorie.PhoneNumber,
                "pin" => PIIConfigCategorie.Pin,
                "ssn" => PIIConfigCategorie.Ssn,
                _ => null,
            };
        }
    }
}