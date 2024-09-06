//HintName: G.Models.PiiPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of PII to redact
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PiiPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="account_number")]
        AccountNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="banking_information")]
        BankingInformation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blood_type")]
        BloodType,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credit_card_cvv")]
        CreditCardCvv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credit_card_expiration")]
        CreditCardExpiration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credit_card_number")]
        CreditCardNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date")]
        Date,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date_interval")]
        DateInterval,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date_of_birth")]
        DateOfBirth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="drivers_license")]
        DriversLicense,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="drug")]
        Drug,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="duration")]
        Duration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="email_address")]
        EmailAddress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="event")]
        Event,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="filename")]
        Filename,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gender_sexuality")]
        GenderSexuality,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="healthcare_number")]
        HealthcareNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="injury")]
        Injury,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ip_address")]
        IpAddress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language")]
        Language,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="location")]
        Location,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="marital_status")]
        MaritalStatus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medical_condition")]
        MedicalCondition,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medical_process")]
        MedicalProcess,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="money_amount")]
        MoneyAmount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nationality")]
        Nationality,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number_sequence")]
        NumberSequence,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="occupation")]
        Occupation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="passport_number")]
        PassportNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="password")]
        Password,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="person_age")]
        PersonAge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="person_name")]
        PersonName,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone_number")]
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="physical_attribute")]
        PhysicalAttribute,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="political_affiliation")]
        PoliticalAffiliation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="religion")]
        Religion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="statistics")]
        Statistics,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="time")]
        Time,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="us_social_security_number")]
        UsSocialSecurityNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="username")]
        Username,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vehicle_id")]
        VehicleId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zodiac_sign")]
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