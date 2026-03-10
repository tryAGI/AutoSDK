//HintName: G.Models.ConfigEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Entity types for the API configuration.<br/>
    /// This enum contains all valid entity type configurations that users can specify:<br/>
    /// - Parent types (e.g., "name", "financial_id") that expand to all subtypes<br/>
    /// - Specific subtypes using dot notation (e.g., "name.full_name")<br/>
    /// - Standalone terminal types (e.g., "email_address")<br/>
    /// When converted for service use, parent types expand to all their terminal subtypes.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConfigEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name")]
        Name,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name.name_given")]
        NameNameGiven,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name.name_family")]
        NameNameFamily,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="name.name_other")]
        NameNameOther,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="email_address")]
        EmailAddress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contact_number")]
        ContactNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dob")]
        Dob,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="age")]
        Age,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="religious_belief")]
        ReligiousBelief,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="political_opinion")]
        PoliticalOpinion,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sexual_orientation")]
        SexualOrientation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ethnicity_race")]
        EthnicityRace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="marital_status")]
        MaritalStatus,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="occupation")]
        Occupation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="physical_attribute")]
        PhysicalAttribute,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="language")]
        Language,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="username")]
        Username,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="password")]
        Password,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url")]
        Url,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="financial_id")]
        FinancialId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="financial_id.payment_card")]
        FinancialIdPaymentCard,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="financial_id.payment_card.payment_card_number")]
        FinancialIdPaymentCardPaymentCardNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="financial_id.payment_card.payment_card_expiration_date")]
        FinancialIdPaymentCardPaymentCardExpirationDate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="financial_id.payment_card.payment_card_cvv")]
        FinancialIdPaymentCardPaymentCardCvv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="financial_id.bank_account")]
        FinancialIdBankAccount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="financial_id.bank_account.bank_account_number")]
        FinancialIdBankAccountBankAccountNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="financial_id.bank_account.bank_routing_number")]
        FinancialIdBankAccountBankRoutingNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="financial_id.bank_account.swift_bic_code")]
        FinancialIdBankAccountSwiftBicCode,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="financial_id.financial_id_other")]
        FinancialIdFinancialIdOther,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="location")]
        Location,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="location.location_address")]
        LocationLocationAddress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="location.location_city")]
        LocationLocationCity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="location.location_postal_code")]
        LocationLocationPostalCode,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="location.location_coordinate")]
        LocationLocationCoordinate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="location.location_state")]
        LocationLocationState,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="location.location_country")]
        LocationLocationCountry,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="location.location_other")]
        LocationLocationOther,
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
        [global::System.Runtime.Serialization.EnumMember(Value="unique_id")]
        UniqueId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unique_id.government_issued_id")]
        UniqueIdGovernmentIssuedId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unique_id.account_number")]
        UniqueIdAccountNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unique_id.vehicle_id")]
        UniqueIdVehicleId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unique_id.healthcare_number")]
        UniqueIdHealthcareNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unique_id.healthcare_number.medical_record_number")]
        UniqueIdHealthcareNumberMedicalRecordNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unique_id.healthcare_number.health_plan_beneficiary_number")]
        UniqueIdHealthcareNumberHealthPlanBeneficiaryNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unique_id.device_id")]
        UniqueIdDeviceId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="unique_id.unique_id_other")]
        UniqueIdUniqueIdOther,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medical")]
        Medical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medical.medical_condition")]
        MedicalMedicalCondition,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medical.medication")]
        MedicalMedication,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medical.medical_procedure")]
        MedicalMedicalProcedure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medical.medical_measurement")]
        MedicalMedicalMeasurement,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medical.medical_other")]
        MedicalMedicalOther,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConfigEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConfigEntityType value)
        {
            return value switch
            {
                ConfigEntityType.Name => "name",
                ConfigEntityType.NameNameGiven => "name.name_given",
                ConfigEntityType.NameNameFamily => "name.name_family",
                ConfigEntityType.NameNameOther => "name.name_other",
                ConfigEntityType.EmailAddress => "email_address",
                ConfigEntityType.ContactNumber => "contact_number",
                ConfigEntityType.Dob => "dob",
                ConfigEntityType.Age => "age",
                ConfigEntityType.ReligiousBelief => "religious_belief",
                ConfigEntityType.PoliticalOpinion => "political_opinion",
                ConfigEntityType.SexualOrientation => "sexual_orientation",
                ConfigEntityType.EthnicityRace => "ethnicity_race",
                ConfigEntityType.MaritalStatus => "marital_status",
                ConfigEntityType.Occupation => "occupation",
                ConfigEntityType.PhysicalAttribute => "physical_attribute",
                ConfigEntityType.Language => "language",
                ConfigEntityType.Username => "username",
                ConfigEntityType.Password => "password",
                ConfigEntityType.Url => "url",
                ConfigEntityType.Organization => "organization",
                ConfigEntityType.FinancialId => "financial_id",
                ConfigEntityType.FinancialIdPaymentCard => "financial_id.payment_card",
                ConfigEntityType.FinancialIdPaymentCardPaymentCardNumber => "financial_id.payment_card.payment_card_number",
                ConfigEntityType.FinancialIdPaymentCardPaymentCardExpirationDate => "financial_id.payment_card.payment_card_expiration_date",
                ConfigEntityType.FinancialIdPaymentCardPaymentCardCvv => "financial_id.payment_card.payment_card_cvv",
                ConfigEntityType.FinancialIdBankAccount => "financial_id.bank_account",
                ConfigEntityType.FinancialIdBankAccountBankAccountNumber => "financial_id.bank_account.bank_account_number",
                ConfigEntityType.FinancialIdBankAccountBankRoutingNumber => "financial_id.bank_account.bank_routing_number",
                ConfigEntityType.FinancialIdBankAccountSwiftBicCode => "financial_id.bank_account.swift_bic_code",
                ConfigEntityType.FinancialIdFinancialIdOther => "financial_id.financial_id_other",
                ConfigEntityType.Location => "location",
                ConfigEntityType.LocationLocationAddress => "location.location_address",
                ConfigEntityType.LocationLocationCity => "location.location_city",
                ConfigEntityType.LocationLocationPostalCode => "location.location_postal_code",
                ConfigEntityType.LocationLocationCoordinate => "location.location_coordinate",
                ConfigEntityType.LocationLocationState => "location.location_state",
                ConfigEntityType.LocationLocationCountry => "location.location_country",
                ConfigEntityType.LocationLocationOther => "location.location_other",
                ConfigEntityType.Date => "date",
                ConfigEntityType.DateInterval => "date_interval",
                ConfigEntityType.UniqueId => "unique_id",
                ConfigEntityType.UniqueIdGovernmentIssuedId => "unique_id.government_issued_id",
                ConfigEntityType.UniqueIdAccountNumber => "unique_id.account_number",
                ConfigEntityType.UniqueIdVehicleId => "unique_id.vehicle_id",
                ConfigEntityType.UniqueIdHealthcareNumber => "unique_id.healthcare_number",
                ConfigEntityType.UniqueIdHealthcareNumberMedicalRecordNumber => "unique_id.healthcare_number.medical_record_number",
                ConfigEntityType.UniqueIdHealthcareNumberHealthPlanBeneficiaryNumber => "unique_id.healthcare_number.health_plan_beneficiary_number",
                ConfigEntityType.UniqueIdDeviceId => "unique_id.device_id",
                ConfigEntityType.UniqueIdUniqueIdOther => "unique_id.unique_id_other",
                ConfigEntityType.Medical => "medical",
                ConfigEntityType.MedicalMedicalCondition => "medical.medical_condition",
                ConfigEntityType.MedicalMedication => "medical.medication",
                ConfigEntityType.MedicalMedicalProcedure => "medical.medical_procedure",
                ConfigEntityType.MedicalMedicalMeasurement => "medical.medical_measurement",
                ConfigEntityType.MedicalMedicalOther => "medical.medical_other",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConfigEntityType? ToEnum(string value)
        {
            return value switch
            {
                "name" => ConfigEntityType.Name,
                "name.name_given" => ConfigEntityType.NameNameGiven,
                "name.name_family" => ConfigEntityType.NameNameFamily,
                "name.name_other" => ConfigEntityType.NameNameOther,
                "email_address" => ConfigEntityType.EmailAddress,
                "contact_number" => ConfigEntityType.ContactNumber,
                "dob" => ConfigEntityType.Dob,
                "age" => ConfigEntityType.Age,
                "religious_belief" => ConfigEntityType.ReligiousBelief,
                "political_opinion" => ConfigEntityType.PoliticalOpinion,
                "sexual_orientation" => ConfigEntityType.SexualOrientation,
                "ethnicity_race" => ConfigEntityType.EthnicityRace,
                "marital_status" => ConfigEntityType.MaritalStatus,
                "occupation" => ConfigEntityType.Occupation,
                "physical_attribute" => ConfigEntityType.PhysicalAttribute,
                "language" => ConfigEntityType.Language,
                "username" => ConfigEntityType.Username,
                "password" => ConfigEntityType.Password,
                "url" => ConfigEntityType.Url,
                "organization" => ConfigEntityType.Organization,
                "financial_id" => ConfigEntityType.FinancialId,
                "financial_id.payment_card" => ConfigEntityType.FinancialIdPaymentCard,
                "financial_id.payment_card.payment_card_number" => ConfigEntityType.FinancialIdPaymentCardPaymentCardNumber,
                "financial_id.payment_card.payment_card_expiration_date" => ConfigEntityType.FinancialIdPaymentCardPaymentCardExpirationDate,
                "financial_id.payment_card.payment_card_cvv" => ConfigEntityType.FinancialIdPaymentCardPaymentCardCvv,
                "financial_id.bank_account" => ConfigEntityType.FinancialIdBankAccount,
                "financial_id.bank_account.bank_account_number" => ConfigEntityType.FinancialIdBankAccountBankAccountNumber,
                "financial_id.bank_account.bank_routing_number" => ConfigEntityType.FinancialIdBankAccountBankRoutingNumber,
                "financial_id.bank_account.swift_bic_code" => ConfigEntityType.FinancialIdBankAccountSwiftBicCode,
                "financial_id.financial_id_other" => ConfigEntityType.FinancialIdFinancialIdOther,
                "location" => ConfigEntityType.Location,
                "location.location_address" => ConfigEntityType.LocationLocationAddress,
                "location.location_city" => ConfigEntityType.LocationLocationCity,
                "location.location_postal_code" => ConfigEntityType.LocationLocationPostalCode,
                "location.location_coordinate" => ConfigEntityType.LocationLocationCoordinate,
                "location.location_state" => ConfigEntityType.LocationLocationState,
                "location.location_country" => ConfigEntityType.LocationLocationCountry,
                "location.location_other" => ConfigEntityType.LocationLocationOther,
                "date" => ConfigEntityType.Date,
                "date_interval" => ConfigEntityType.DateInterval,
                "unique_id" => ConfigEntityType.UniqueId,
                "unique_id.government_issued_id" => ConfigEntityType.UniqueIdGovernmentIssuedId,
                "unique_id.account_number" => ConfigEntityType.UniqueIdAccountNumber,
                "unique_id.vehicle_id" => ConfigEntityType.UniqueIdVehicleId,
                "unique_id.healthcare_number" => ConfigEntityType.UniqueIdHealthcareNumber,
                "unique_id.healthcare_number.medical_record_number" => ConfigEntityType.UniqueIdHealthcareNumberMedicalRecordNumber,
                "unique_id.healthcare_number.health_plan_beneficiary_number" => ConfigEntityType.UniqueIdHealthcareNumberHealthPlanBeneficiaryNumber,
                "unique_id.device_id" => ConfigEntityType.UniqueIdDeviceId,
                "unique_id.unique_id_other" => ConfigEntityType.UniqueIdUniqueIdOther,
                "medical" => ConfigEntityType.Medical,
                "medical.medical_condition" => ConfigEntityType.MedicalMedicalCondition,
                "medical.medication" => ConfigEntityType.MedicalMedication,
                "medical.medical_procedure" => ConfigEntityType.MedicalMedicalProcedure,
                "medical.medical_measurement" => ConfigEntityType.MedicalMedicalMeasurement,
                "medical.medical_other" => ConfigEntityType.MedicalMedicalOther,
                _ => null,
            };
        }
    }
}