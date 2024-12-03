//HintName: G.Models.PiiPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of PII to redact
    /// </summary>
    public enum PiiPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        AccountNumber,
        /// <summary>
        /// 
        /// </summary>
        BankingInformation,
        /// <summary>
        /// 
        /// </summary>
        BloodType,
        /// <summary>
        /// 
        /// </summary>
        CreditCardCvv,
        /// <summary>
        /// 
        /// </summary>
        CreditCardExpiration,
        /// <summary>
        /// 
        /// </summary>
        CreditCardNumber,
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        DateInterval,
        /// <summary>
        /// 
        /// </summary>
        DateOfBirth,
        /// <summary>
        /// 
        /// </summary>
        DriversLicense,
        /// <summary>
        /// 
        /// </summary>
        Drug,
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        EmailAddress,
        /// <summary>
        /// 
        /// </summary>
        Event,
        /// <summary>
        /// 
        /// </summary>
        Filename,
        /// <summary>
        /// 
        /// </summary>
        GenderSexuality,
        /// <summary>
        /// 
        /// </summary>
        HealthcareNumber,
        /// <summary>
        /// 
        /// </summary>
        Injury,
        /// <summary>
        /// 
        /// </summary>
        IpAddress,
        /// <summary>
        /// 
        /// </summary>
        Language,
        /// <summary>
        /// 
        /// </summary>
        Location,
        /// <summary>
        /// 
        /// </summary>
        MaritalStatus,
        /// <summary>
        /// 
        /// </summary>
        MedicalCondition,
        /// <summary>
        /// 
        /// </summary>
        MedicalProcess,
        /// <summary>
        /// 
        /// </summary>
        MoneyAmount,
        /// <summary>
        /// 
        /// </summary>
        Nationality,
        /// <summary>
        /// 
        /// </summary>
        NumberSequence,
        /// <summary>
        /// 
        /// </summary>
        Occupation,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        PassportNumber,
        /// <summary>
        /// 
        /// </summary>
        Password,
        /// <summary>
        /// 
        /// </summary>
        PersonAge,
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
        PhysicalAttribute,
        /// <summary>
        /// 
        /// </summary>
        PoliticalAffiliation,
        /// <summary>
        /// 
        /// </summary>
        Religion,
        /// <summary>
        /// 
        /// </summary>
        Statistics,
        /// <summary>
        /// 
        /// </summary>
        Time,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        UsSocialSecurityNumber,
        /// <summary>
        /// 
        /// </summary>
        Username,
        /// <summary>
        /// 
        /// </summary>
        VehicleId,
        /// <summary>
        /// 
        /// </summary>
        ZodiacSign,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PiiPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PiiPolicy value)
        {
            return value switch
            {
                PiiPolicy.AccountNumber => "account_number",
                PiiPolicy.BankingInformation => "banking_information",
                PiiPolicy.BloodType => "blood_type",
                PiiPolicy.CreditCardCvv => "credit_card_cvv",
                PiiPolicy.CreditCardExpiration => "credit_card_expiration",
                PiiPolicy.CreditCardNumber => "credit_card_number",
                PiiPolicy.Date => "date",
                PiiPolicy.DateInterval => "date_interval",
                PiiPolicy.DateOfBirth => "date_of_birth",
                PiiPolicy.DriversLicense => "drivers_license",
                PiiPolicy.Drug => "drug",
                PiiPolicy.Duration => "duration",
                PiiPolicy.EmailAddress => "email_address",
                PiiPolicy.Event => "event",
                PiiPolicy.Filename => "filename",
                PiiPolicy.GenderSexuality => "gender_sexuality",
                PiiPolicy.HealthcareNumber => "healthcare_number",
                PiiPolicy.Injury => "injury",
                PiiPolicy.IpAddress => "ip_address",
                PiiPolicy.Language => "language",
                PiiPolicy.Location => "location",
                PiiPolicy.MaritalStatus => "marital_status",
                PiiPolicy.MedicalCondition => "medical_condition",
                PiiPolicy.MedicalProcess => "medical_process",
                PiiPolicy.MoneyAmount => "money_amount",
                PiiPolicy.Nationality => "nationality",
                PiiPolicy.NumberSequence => "number_sequence",
                PiiPolicy.Occupation => "occupation",
                PiiPolicy.Organization => "organization",
                PiiPolicy.PassportNumber => "passport_number",
                PiiPolicy.Password => "password",
                PiiPolicy.PersonAge => "person_age",
                PiiPolicy.PersonName => "person_name",
                PiiPolicy.PhoneNumber => "phone_number",
                PiiPolicy.PhysicalAttribute => "physical_attribute",
                PiiPolicy.PoliticalAffiliation => "political_affiliation",
                PiiPolicy.Religion => "religion",
                PiiPolicy.Statistics => "statistics",
                PiiPolicy.Time => "time",
                PiiPolicy.Url => "url",
                PiiPolicy.UsSocialSecurityNumber => "us_social_security_number",
                PiiPolicy.Username => "username",
                PiiPolicy.VehicleId => "vehicle_id",
                PiiPolicy.ZodiacSign => "zodiac_sign",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PiiPolicy? ToEnum(string value)
        {
            return value switch
            {
                "account_number" => PiiPolicy.AccountNumber,
                "banking_information" => PiiPolicy.BankingInformation,
                "blood_type" => PiiPolicy.BloodType,
                "credit_card_cvv" => PiiPolicy.CreditCardCvv,
                "credit_card_expiration" => PiiPolicy.CreditCardExpiration,
                "credit_card_number" => PiiPolicy.CreditCardNumber,
                "date" => PiiPolicy.Date,
                "date_interval" => PiiPolicy.DateInterval,
                "date_of_birth" => PiiPolicy.DateOfBirth,
                "drivers_license" => PiiPolicy.DriversLicense,
                "drug" => PiiPolicy.Drug,
                "duration" => PiiPolicy.Duration,
                "email_address" => PiiPolicy.EmailAddress,
                "event" => PiiPolicy.Event,
                "filename" => PiiPolicy.Filename,
                "gender_sexuality" => PiiPolicy.GenderSexuality,
                "healthcare_number" => PiiPolicy.HealthcareNumber,
                "injury" => PiiPolicy.Injury,
                "ip_address" => PiiPolicy.IpAddress,
                "language" => PiiPolicy.Language,
                "location" => PiiPolicy.Location,
                "marital_status" => PiiPolicy.MaritalStatus,
                "medical_condition" => PiiPolicy.MedicalCondition,
                "medical_process" => PiiPolicy.MedicalProcess,
                "money_amount" => PiiPolicy.MoneyAmount,
                "nationality" => PiiPolicy.Nationality,
                "number_sequence" => PiiPolicy.NumberSequence,
                "occupation" => PiiPolicy.Occupation,
                "organization" => PiiPolicy.Organization,
                "passport_number" => PiiPolicy.PassportNumber,
                "password" => PiiPolicy.Password,
                "person_age" => PiiPolicy.PersonAge,
                "person_name" => PiiPolicy.PersonName,
                "phone_number" => PiiPolicy.PhoneNumber,
                "physical_attribute" => PiiPolicy.PhysicalAttribute,
                "political_affiliation" => PiiPolicy.PoliticalAffiliation,
                "religion" => PiiPolicy.Religion,
                "statistics" => PiiPolicy.Statistics,
                "time" => PiiPolicy.Time,
                "url" => PiiPolicy.Url,
                "us_social_security_number" => PiiPolicy.UsSocialSecurityNumber,
                "username" => PiiPolicy.Username,
                "vehicle_id" => PiiPolicy.VehicleId,
                "zodiac_sign" => PiiPolicy.ZodiacSign,
                _ => null,
            };
        }
    }
}