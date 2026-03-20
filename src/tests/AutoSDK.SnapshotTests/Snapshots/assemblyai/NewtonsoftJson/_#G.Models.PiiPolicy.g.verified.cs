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
        /// Customer account or membership identification number (e.g., Policy No. 10042992, Member ID: HZ-5235-001)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="account_number")]
        AccountNumber,
        /// <summary>
        /// Banking information, including account and routing numbers
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="banking_information")]
        BankingInformation,
        /// <summary>
        /// Blood type (e.g., O-, AB positive)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blood_type")]
        BloodType,
        /// <summary>
        /// Credit card verification code (e.g., CVV: 080)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credit_card_cvv")]
        CreditCardCvv,
        /// <summary>
        /// Expiration date of a credit card
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credit_card_expiration")]
        CreditCardExpiration,
        /// <summary>
        /// Credit card number
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credit_card_number")]
        CreditCardNumber,
        /// <summary>
        /// Specific calendar date (e.g., December 18)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date")]
        Date,
        /// <summary>
        /// Broader time periods, including date ranges, months, seasons, years, and decades (e.g., 2020-2021, 5-9 May, January 1984)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date_interval")]
        DateInterval,
        /// <summary>
        /// Date of birth (e.g., Date of Birth: March 7,1961)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date_of_birth")]
        DateOfBirth,
        /// <summary>
        /// Driver's license number. (e.g., DL# 356933-540)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="drivers_license")]
        DriversLicense,
        /// <summary>
        /// Medications, vitamins, or supplements (e.g., Advil, Acetaminophen, Panadol)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="drug")]
        Drug,
        /// <summary>
        /// Periods of time, specified as a number and a unit of time (e.g., 8 months, 2 years)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="duration")]
        Duration,
        /// <summary>
        /// Email address (e.g., support@assemblyai.com)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="email_address")]
        EmailAddress,
        /// <summary>
        /// Name of an event or holiday (e.g., Olympics, Yom Kippur)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="event")]
        Event,
        /// <summary>
        /// Names of computer files, including the extension or filepath (e.g., Taxes/2012/brad-tax-returns.pdf)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="filename")]
        Filename,
        /// <summary>
        /// Terms indicating gender identity or sexual orientation, including slang terms (e.g., female, bisexual, trans)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gender_sexuality")]
        GenderSexuality,
        /// <summary>
        /// Healthcare numbers and health plan beneficiary numbers (e.g., Policy No.: 5584-486-674-YM)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="healthcare_number")]
        HealthcareNumber,
        /// <summary>
        /// Bodily injury (e.g., I broke my arm, I have a sprained wrist)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="injury")]
        Injury,
        /// <summary>
        /// Internet IP address, including IPv4 and IPv6 formats (e.g., 192.168.0.1)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ip_address")]
        IpAddress,
        /// <summary>
        /// Name of a natural language (e.g., Spanish, French)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language")]
        Language,
        /// <summary>
        /// Any Location reference including mailing address, postal code, city, state, province, country, or coordinates. (e.g., Lake Victoria, 145 Windsor St., 90210)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="location")]
        Location,
        /// <summary>
        /// Terms indicating marital status (e.g., Single, common-law, ex-wife, married)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="marital_status")]
        MaritalStatus,
        /// <summary>
        /// Name of a medical condition, disease, syndrome, deficit, or disorder (e.g., chronic fatigue syndrome, arrhythmia, depression)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medical_condition")]
        MedicalCondition,
        /// <summary>
        /// Medical process, including treatments, procedures, and tests (e.g., heart surgery, CT scan)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medical_process")]
        MedicalProcess,
        /// <summary>
        /// Name and/or amount of currency (e.g., 15 pesos, $94.50)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="money_amount")]
        MoneyAmount,
        /// <summary>
        /// Terms indicating nationality, ethnicity, or race (e.g., American, Asian, Caucasian)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nationality")]
        Nationality,
        /// <summary>
        /// Numerical PII (including alphanumeric strings) that doesn't fall under other categories
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number_sequence")]
        NumberSequence,
        /// <summary>
        /// Job title or profession (e.g., professor, actors, engineer, CPA)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="occupation")]
        Occupation,
        /// <summary>
        /// Name of an organization (e.g., CNN, McDonalds, University of Alaska, Northwest General Hospital)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// Passport numbers, issued by any country (e.g., PA4568332, NU3C6L86S12)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="passport_number")]
        PassportNumber,
        /// <summary>
        /// Account passwords, PINs, access keys, or verification answers (e.g., 27%alfalfa, temp1234, My mother's maiden name is Smith)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="password")]
        Password,
        /// <summary>
        /// Number associated with an age (e.g., 27, 75)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="person_age")]
        PersonAge,
        /// <summary>
        /// Name of a person (e.g., Bob, Doug Jones, Dr. Kay Martinez, MD)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="person_name")]
        PersonName,
        /// <summary>
        /// Telephone or fax number
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phone_number")]
        PhoneNumber,
        /// <summary>
        /// Distinctive bodily attributes, including terms indicating race (e.g., I'm 190cm tall, He belongs to the Black students' association)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="physical_attribute")]
        PhysicalAttribute,
        /// <summary>
        /// Terms referring to a political party, movement, or ideology (e.g., Republican, Liberal)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="political_affiliation")]
        PoliticalAffiliation,
        /// <summary>
        /// Terms indicating religious affiliation (e.g., Hindu, Catholic)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="religion")]
        Religion,
        /// <summary>
        /// Medical statistics (e.g., 18%, 18 percent)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="statistics")]
        Statistics,
        /// <summary>
        /// Expressions indicating clock times (e.g., 19:37:28, 10pm EST)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="time")]
        Time,
        /// <summary>
        /// Internet addresses (e.g., https://www.assemblyai.com/)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
        /// <summary>
        /// Social Security Number or equivalent
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="us_social_security_number")]
        UsSocialSecurityNumber,
        /// <summary>
        /// Usernames, login names, or handles (e.g., @AssemblyAI)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="username")]
        Username,
        /// <summary>
        /// Vehicle identification numbers (VINs), vehicle serial numbers, and license plate numbers (e.g., 5FNRL38918B111818, BIF7547)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vehicle_id")]
        VehicleId,
        /// <summary>
        /// Names of Zodiac signs (e.g., Aries, Taurus)
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