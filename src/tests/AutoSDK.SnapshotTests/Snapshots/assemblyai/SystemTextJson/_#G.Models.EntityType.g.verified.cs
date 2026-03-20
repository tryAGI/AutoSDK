//HintName: G.Models.EntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of entity for the detected entity
    /// </summary>
    public enum EntityType
    {
        /// <summary>
        /// Customer account or membership identification number (e.g., Policy No. 10042992, Member ID: HZ-5235-001)
        /// </summary>
        AccountNumber,
        /// <summary>
        /// Banking information, including account and routing numbers
        /// </summary>
        BankingInformation,
        /// <summary>
        /// Blood type (e.g., O-, AB positive)
        /// </summary>
        BloodType,
        /// <summary>
        /// Credit card verification code (e.g., CVV: 080)
        /// </summary>
        CreditCardCvv,
        /// <summary>
        /// Expiration date of a credit card
        /// </summary>
        CreditCardExpiration,
        /// <summary>
        /// Credit card number
        /// </summary>
        CreditCardNumber,
        /// <summary>
        /// Specific calendar date (e.g., December 18)
        /// </summary>
        Date,
        /// <summary>
        /// Broader time periods, including date ranges, months, seasons, years, and decades (e.g., 2020-2021, 5-9 May, January 1984)
        /// </summary>
        DateInterval,
        /// <summary>
        /// Date of birth (e.g., Date of Birth: March 7,1961)
        /// </summary>
        DateOfBirth,
        /// <summary>
        /// Driver's license number. (e.g., DL# 356933-540)
        /// </summary>
        DriversLicense,
        /// <summary>
        /// Medications, vitamins, or supplements (e.g., Advil, Acetaminophen, Panadol)
        /// </summary>
        Drug,
        /// <summary>
        /// Periods of time, specified as a number and a unit of time (e.g., 8 months, 2 years)
        /// </summary>
        Duration,
        /// <summary>
        /// Email address (e.g., support@assemblyai.com)
        /// </summary>
        EmailAddress,
        /// <summary>
        /// Name of an event or holiday (e.g., Olympics, Yom Kippur)
        /// </summary>
        Event,
        /// <summary>
        /// Names of computer files, including the extension or filepath (e.g., Taxes/2012/brad-tax-returns.pdf)
        /// </summary>
        Filename,
        /// <summary>
        /// Terms indicating gender identity or sexual orientation, including slang terms (e.g., female, bisexual, trans)
        /// </summary>
        GenderSexuality,
        /// <summary>
        /// Healthcare numbers and health plan beneficiary numbers (e.g., Policy No.: 5584-486-674-YM)
        /// </summary>
        HealthcareNumber,
        /// <summary>
        /// Bodily injury (e.g., I broke my arm, I have a sprained wrist)
        /// </summary>
        Injury,
        /// <summary>
        /// Internet IP address, including IPv4 and IPv6 formats (e.g., 192.168.0.1)
        /// </summary>
        IpAddress,
        /// <summary>
        /// Name of a natural language (e.g., Spanish, French)
        /// </summary>
        Language,
        /// <summary>
        /// Any Location reference including mailing address, postal code, city, state, province, country, or coordinates. (e.g., Lake Victoria, 145 Windsor St., 90210)
        /// </summary>
        Location,
        /// <summary>
        /// Terms indicating marital status (e.g., Single, common-law, ex-wife, married)
        /// </summary>
        MaritalStatus,
        /// <summary>
        /// Name of a medical condition, disease, syndrome, deficit, or disorder (e.g., chronic fatigue syndrome, arrhythmia, depression)
        /// </summary>
        MedicalCondition,
        /// <summary>
        /// Medical process, including treatments, procedures, and tests (e.g., heart surgery, CT scan)
        /// </summary>
        MedicalProcess,
        /// <summary>
        /// Name and/or amount of currency (e.g., 15 pesos, $94.50)
        /// </summary>
        MoneyAmount,
        /// <summary>
        /// Terms indicating nationality, ethnicity, or race (e.g., American, Asian, Caucasian)
        /// </summary>
        Nationality,
        /// <summary>
        /// Numerical PII (including alphanumeric strings) that doesn't fall under other categories
        /// </summary>
        NumberSequence,
        /// <summary>
        /// Job title or profession (e.g., professor, actors, engineer, CPA)
        /// </summary>
        Occupation,
        /// <summary>
        /// Name of an organization (e.g., CNN, McDonalds, University of Alaska, Northwest General Hospital)
        /// </summary>
        Organization,
        /// <summary>
        /// Passport numbers, issued by any country (e.g., PA4568332, NU3C6L86S12)
        /// </summary>
        PassportNumber,
        /// <summary>
        /// Account passwords, PINs, access keys, or verification answers (e.g., 27%alfalfa, temp1234, My mother's maiden name is Smith)
        /// </summary>
        Password,
        /// <summary>
        /// Number associated with an age (e.g., 27, 75)
        /// </summary>
        PersonAge,
        /// <summary>
        /// Name of a person (e.g., Bob, Doug Jones, Dr. Kay Martinez, MD)
        /// </summary>
        PersonName,
        /// <summary>
        /// Telephone or fax number
        /// </summary>
        PhoneNumber,
        /// <summary>
        /// Distinctive bodily attributes, including terms indicating race (e.g., I'm 190cm tall, He belongs to the Black students' association)
        /// </summary>
        PhysicalAttribute,
        /// <summary>
        /// Terms referring to a political party, movement, or ideology (e.g., Republican, Liberal)
        /// </summary>
        PoliticalAffiliation,
        /// <summary>
        /// Terms indicating religious affiliation (e.g., Hindu, Catholic)
        /// </summary>
        Religion,
        /// <summary>
        /// Medical statistics (e.g., 18%, 18 percent)
        /// </summary>
        Statistics,
        /// <summary>
        /// Expressions indicating clock times (e.g., 19:37:28, 10pm EST)
        /// </summary>
        Time,
        /// <summary>
        /// Internet addresses (e.g., https://www.assemblyai.com/)
        /// </summary>
        Url,
        /// <summary>
        /// Social Security Number or equivalent
        /// </summary>
        UsSocialSecurityNumber,
        /// <summary>
        /// Usernames, login names, or handles (e.g., @AssemblyAI)
        /// </summary>
        Username,
        /// <summary>
        /// Vehicle identification numbers (VINs), vehicle serial numbers, and license plate numbers (e.g., 5FNRL38918B111818, BIF7547)
        /// </summary>
        VehicleId,
        /// <summary>
        /// Names of Zodiac signs (e.g., Aries, Taurus)
        /// </summary>
        ZodiacSign,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityType value)
        {
            return value switch
            {
                EntityType.AccountNumber => "account_number",
                EntityType.BankingInformation => "banking_information",
                EntityType.BloodType => "blood_type",
                EntityType.CreditCardCvv => "credit_card_cvv",
                EntityType.CreditCardExpiration => "credit_card_expiration",
                EntityType.CreditCardNumber => "credit_card_number",
                EntityType.Date => "date",
                EntityType.DateInterval => "date_interval",
                EntityType.DateOfBirth => "date_of_birth",
                EntityType.DriversLicense => "drivers_license",
                EntityType.Drug => "drug",
                EntityType.Duration => "duration",
                EntityType.EmailAddress => "email_address",
                EntityType.Event => "event",
                EntityType.Filename => "filename",
                EntityType.GenderSexuality => "gender_sexuality",
                EntityType.HealthcareNumber => "healthcare_number",
                EntityType.Injury => "injury",
                EntityType.IpAddress => "ip_address",
                EntityType.Language => "language",
                EntityType.Location => "location",
                EntityType.MaritalStatus => "marital_status",
                EntityType.MedicalCondition => "medical_condition",
                EntityType.MedicalProcess => "medical_process",
                EntityType.MoneyAmount => "money_amount",
                EntityType.Nationality => "nationality",
                EntityType.NumberSequence => "number_sequence",
                EntityType.Occupation => "occupation",
                EntityType.Organization => "organization",
                EntityType.PassportNumber => "passport_number",
                EntityType.Password => "password",
                EntityType.PersonAge => "person_age",
                EntityType.PersonName => "person_name",
                EntityType.PhoneNumber => "phone_number",
                EntityType.PhysicalAttribute => "physical_attribute",
                EntityType.PoliticalAffiliation => "political_affiliation",
                EntityType.Religion => "religion",
                EntityType.Statistics => "statistics",
                EntityType.Time => "time",
                EntityType.Url => "url",
                EntityType.UsSocialSecurityNumber => "us_social_security_number",
                EntityType.Username => "username",
                EntityType.VehicleId => "vehicle_id",
                EntityType.ZodiacSign => "zodiac_sign",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityType? ToEnum(string value)
        {
            return value switch
            {
                "account_number" => EntityType.AccountNumber,
                "banking_information" => EntityType.BankingInformation,
                "blood_type" => EntityType.BloodType,
                "credit_card_cvv" => EntityType.CreditCardCvv,
                "credit_card_expiration" => EntityType.CreditCardExpiration,
                "credit_card_number" => EntityType.CreditCardNumber,
                "date" => EntityType.Date,
                "date_interval" => EntityType.DateInterval,
                "date_of_birth" => EntityType.DateOfBirth,
                "drivers_license" => EntityType.DriversLicense,
                "drug" => EntityType.Drug,
                "duration" => EntityType.Duration,
                "email_address" => EntityType.EmailAddress,
                "event" => EntityType.Event,
                "filename" => EntityType.Filename,
                "gender_sexuality" => EntityType.GenderSexuality,
                "healthcare_number" => EntityType.HealthcareNumber,
                "injury" => EntityType.Injury,
                "ip_address" => EntityType.IpAddress,
                "language" => EntityType.Language,
                "location" => EntityType.Location,
                "marital_status" => EntityType.MaritalStatus,
                "medical_condition" => EntityType.MedicalCondition,
                "medical_process" => EntityType.MedicalProcess,
                "money_amount" => EntityType.MoneyAmount,
                "nationality" => EntityType.Nationality,
                "number_sequence" => EntityType.NumberSequence,
                "occupation" => EntityType.Occupation,
                "organization" => EntityType.Organization,
                "passport_number" => EntityType.PassportNumber,
                "password" => EntityType.Password,
                "person_age" => EntityType.PersonAge,
                "person_name" => EntityType.PersonName,
                "phone_number" => EntityType.PhoneNumber,
                "physical_attribute" => EntityType.PhysicalAttribute,
                "political_affiliation" => EntityType.PoliticalAffiliation,
                "religion" => EntityType.Religion,
                "statistics" => EntityType.Statistics,
                "time" => EntityType.Time,
                "url" => EntityType.Url,
                "us_social_security_number" => EntityType.UsSocialSecurityNumber,
                "username" => EntityType.Username,
                "vehicle_id" => EntityType.VehicleId,
                "zodiac_sign" => EntityType.ZodiacSign,
                _ => null,
            };
        }
    }
}