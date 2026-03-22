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
    public enum ConfigEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Age,
        /// <summary>
        /// 
        /// </summary>
        ContactNumber,
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
        Dob,
        /// <summary>
        /// 
        /// </summary>
        EmailAddress,
        /// <summary>
        /// 
        /// </summary>
        EthnicityRace,
        /// <summary>
        /// 
        /// </summary>
        FinancialId,
        /// <summary>
        /// 
        /// </summary>
        FinancialIdBankAccount,
        /// <summary>
        /// 
        /// </summary>
        FinancialIdBankAccountBankAccountNumber,
        /// <summary>
        /// 
        /// </summary>
        FinancialIdBankAccountBankRoutingNumber,
        /// <summary>
        /// 
        /// </summary>
        FinancialIdBankAccountSwiftBicCode,
        /// <summary>
        /// 
        /// </summary>
        FinancialIdFinancialIdOther,
        /// <summary>
        /// 
        /// </summary>
        FinancialIdPaymentCard,
        /// <summary>
        /// 
        /// </summary>
        FinancialIdPaymentCardPaymentCardCvv,
        /// <summary>
        /// 
        /// </summary>
        FinancialIdPaymentCardPaymentCardExpirationDate,
        /// <summary>
        /// 
        /// </summary>
        FinancialIdPaymentCardPaymentCardNumber,
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
        LocationLocationAddress,
        /// <summary>
        /// 
        /// </summary>
        LocationLocationCity,
        /// <summary>
        /// 
        /// </summary>
        LocationLocationCoordinate,
        /// <summary>
        /// 
        /// </summary>
        LocationLocationCountry,
        /// <summary>
        /// 
        /// </summary>
        LocationLocationOther,
        /// <summary>
        /// 
        /// </summary>
        LocationLocationPostalCode,
        /// <summary>
        /// 
        /// </summary>
        LocationLocationState,
        /// <summary>
        /// 
        /// </summary>
        MaritalStatus,
        /// <summary>
        /// 
        /// </summary>
        Medical,
        /// <summary>
        /// 
        /// </summary>
        MedicalMedicalCondition,
        /// <summary>
        /// 
        /// </summary>
        MedicalMedicalMeasurement,
        /// <summary>
        /// 
        /// </summary>
        MedicalMedicalOther,
        /// <summary>
        /// 
        /// </summary>
        MedicalMedicalProcedure,
        /// <summary>
        /// 
        /// </summary>
        MedicalMedication,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        NameNameFamily,
        /// <summary>
        /// 
        /// </summary>
        NameNameGiven,
        /// <summary>
        /// 
        /// </summary>
        NameNameOther,
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
        Password,
        /// <summary>
        /// 
        /// </summary>
        PhysicalAttribute,
        /// <summary>
        /// 
        /// </summary>
        PoliticalOpinion,
        /// <summary>
        /// 
        /// </summary>
        ReligiousBelief,
        /// <summary>
        /// 
        /// </summary>
        SexualOrientation,
        /// <summary>
        /// 
        /// </summary>
        UniqueId,
        /// <summary>
        /// 
        /// </summary>
        UniqueIdAccountNumber,
        /// <summary>
        /// 
        /// </summary>
        UniqueIdDeviceId,
        /// <summary>
        /// 
        /// </summary>
        UniqueIdGovernmentIssuedId,
        /// <summary>
        /// 
        /// </summary>
        UniqueIdHealthcareNumber,
        /// <summary>
        /// 
        /// </summary>
        UniqueIdHealthcareNumberHealthPlanBeneficiaryNumber,
        /// <summary>
        /// 
        /// </summary>
        UniqueIdHealthcareNumberMedicalRecordNumber,
        /// <summary>
        /// 
        /// </summary>
        UniqueIdUniqueIdOther,
        /// <summary>
        /// 
        /// </summary>
        UniqueIdVehicleId,
        /// <summary>
        /// 
        /// </summary>
        Url,
        /// <summary>
        /// 
        /// </summary>
        Username,
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
                ConfigEntityType.Age => "age",
                ConfigEntityType.ContactNumber => "contact_number",
                ConfigEntityType.Date => "date",
                ConfigEntityType.DateInterval => "date_interval",
                ConfigEntityType.Dob => "dob",
                ConfigEntityType.EmailAddress => "email_address",
                ConfigEntityType.EthnicityRace => "ethnicity_race",
                ConfigEntityType.FinancialId => "financial_id",
                ConfigEntityType.FinancialIdBankAccount => "financial_id.bank_account",
                ConfigEntityType.FinancialIdBankAccountBankAccountNumber => "financial_id.bank_account.bank_account_number",
                ConfigEntityType.FinancialIdBankAccountBankRoutingNumber => "financial_id.bank_account.bank_routing_number",
                ConfigEntityType.FinancialIdBankAccountSwiftBicCode => "financial_id.bank_account.swift_bic_code",
                ConfigEntityType.FinancialIdFinancialIdOther => "financial_id.financial_id_other",
                ConfigEntityType.FinancialIdPaymentCard => "financial_id.payment_card",
                ConfigEntityType.FinancialIdPaymentCardPaymentCardCvv => "financial_id.payment_card.payment_card_cvv",
                ConfigEntityType.FinancialIdPaymentCardPaymentCardExpirationDate => "financial_id.payment_card.payment_card_expiration_date",
                ConfigEntityType.FinancialIdPaymentCardPaymentCardNumber => "financial_id.payment_card.payment_card_number",
                ConfigEntityType.Language => "language",
                ConfigEntityType.Location => "location",
                ConfigEntityType.LocationLocationAddress => "location.location_address",
                ConfigEntityType.LocationLocationCity => "location.location_city",
                ConfigEntityType.LocationLocationCoordinate => "location.location_coordinate",
                ConfigEntityType.LocationLocationCountry => "location.location_country",
                ConfigEntityType.LocationLocationOther => "location.location_other",
                ConfigEntityType.LocationLocationPostalCode => "location.location_postal_code",
                ConfigEntityType.LocationLocationState => "location.location_state",
                ConfigEntityType.MaritalStatus => "marital_status",
                ConfigEntityType.Medical => "medical",
                ConfigEntityType.MedicalMedicalCondition => "medical.medical_condition",
                ConfigEntityType.MedicalMedicalMeasurement => "medical.medical_measurement",
                ConfigEntityType.MedicalMedicalOther => "medical.medical_other",
                ConfigEntityType.MedicalMedicalProcedure => "medical.medical_procedure",
                ConfigEntityType.MedicalMedication => "medical.medication",
                ConfigEntityType.Name => "name",
                ConfigEntityType.NameNameFamily => "name.name_family",
                ConfigEntityType.NameNameGiven => "name.name_given",
                ConfigEntityType.NameNameOther => "name.name_other",
                ConfigEntityType.Occupation => "occupation",
                ConfigEntityType.Organization => "organization",
                ConfigEntityType.Password => "password",
                ConfigEntityType.PhysicalAttribute => "physical_attribute",
                ConfigEntityType.PoliticalOpinion => "political_opinion",
                ConfigEntityType.ReligiousBelief => "religious_belief",
                ConfigEntityType.SexualOrientation => "sexual_orientation",
                ConfigEntityType.UniqueId => "unique_id",
                ConfigEntityType.UniqueIdAccountNumber => "unique_id.account_number",
                ConfigEntityType.UniqueIdDeviceId => "unique_id.device_id",
                ConfigEntityType.UniqueIdGovernmentIssuedId => "unique_id.government_issued_id",
                ConfigEntityType.UniqueIdHealthcareNumber => "unique_id.healthcare_number",
                ConfigEntityType.UniqueIdHealthcareNumberHealthPlanBeneficiaryNumber => "unique_id.healthcare_number.health_plan_beneficiary_number",
                ConfigEntityType.UniqueIdHealthcareNumberMedicalRecordNumber => "unique_id.healthcare_number.medical_record_number",
                ConfigEntityType.UniqueIdUniqueIdOther => "unique_id.unique_id_other",
                ConfigEntityType.UniqueIdVehicleId => "unique_id.vehicle_id",
                ConfigEntityType.Url => "url",
                ConfigEntityType.Username => "username",
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
                "age" => ConfigEntityType.Age,
                "contact_number" => ConfigEntityType.ContactNumber,
                "date" => ConfigEntityType.Date,
                "date_interval" => ConfigEntityType.DateInterval,
                "dob" => ConfigEntityType.Dob,
                "email_address" => ConfigEntityType.EmailAddress,
                "ethnicity_race" => ConfigEntityType.EthnicityRace,
                "financial_id" => ConfigEntityType.FinancialId,
                "financial_id.bank_account" => ConfigEntityType.FinancialIdBankAccount,
                "financial_id.bank_account.bank_account_number" => ConfigEntityType.FinancialIdBankAccountBankAccountNumber,
                "financial_id.bank_account.bank_routing_number" => ConfigEntityType.FinancialIdBankAccountBankRoutingNumber,
                "financial_id.bank_account.swift_bic_code" => ConfigEntityType.FinancialIdBankAccountSwiftBicCode,
                "financial_id.financial_id_other" => ConfigEntityType.FinancialIdFinancialIdOther,
                "financial_id.payment_card" => ConfigEntityType.FinancialIdPaymentCard,
                "financial_id.payment_card.payment_card_cvv" => ConfigEntityType.FinancialIdPaymentCardPaymentCardCvv,
                "financial_id.payment_card.payment_card_expiration_date" => ConfigEntityType.FinancialIdPaymentCardPaymentCardExpirationDate,
                "financial_id.payment_card.payment_card_number" => ConfigEntityType.FinancialIdPaymentCardPaymentCardNumber,
                "language" => ConfigEntityType.Language,
                "location" => ConfigEntityType.Location,
                "location.location_address" => ConfigEntityType.LocationLocationAddress,
                "location.location_city" => ConfigEntityType.LocationLocationCity,
                "location.location_coordinate" => ConfigEntityType.LocationLocationCoordinate,
                "location.location_country" => ConfigEntityType.LocationLocationCountry,
                "location.location_other" => ConfigEntityType.LocationLocationOther,
                "location.location_postal_code" => ConfigEntityType.LocationLocationPostalCode,
                "location.location_state" => ConfigEntityType.LocationLocationState,
                "marital_status" => ConfigEntityType.MaritalStatus,
                "medical" => ConfigEntityType.Medical,
                "medical.medical_condition" => ConfigEntityType.MedicalMedicalCondition,
                "medical.medical_measurement" => ConfigEntityType.MedicalMedicalMeasurement,
                "medical.medical_other" => ConfigEntityType.MedicalMedicalOther,
                "medical.medical_procedure" => ConfigEntityType.MedicalMedicalProcedure,
                "medical.medication" => ConfigEntityType.MedicalMedication,
                "name" => ConfigEntityType.Name,
                "name.name_family" => ConfigEntityType.NameNameFamily,
                "name.name_given" => ConfigEntityType.NameNameGiven,
                "name.name_other" => ConfigEntityType.NameNameOther,
                "occupation" => ConfigEntityType.Occupation,
                "organization" => ConfigEntityType.Organization,
                "password" => ConfigEntityType.Password,
                "physical_attribute" => ConfigEntityType.PhysicalAttribute,
                "political_opinion" => ConfigEntityType.PoliticalOpinion,
                "religious_belief" => ConfigEntityType.ReligiousBelief,
                "sexual_orientation" => ConfigEntityType.SexualOrientation,
                "unique_id" => ConfigEntityType.UniqueId,
                "unique_id.account_number" => ConfigEntityType.UniqueIdAccountNumber,
                "unique_id.device_id" => ConfigEntityType.UniqueIdDeviceId,
                "unique_id.government_issued_id" => ConfigEntityType.UniqueIdGovernmentIssuedId,
                "unique_id.healthcare_number" => ConfigEntityType.UniqueIdHealthcareNumber,
                "unique_id.healthcare_number.health_plan_beneficiary_number" => ConfigEntityType.UniqueIdHealthcareNumberHealthPlanBeneficiaryNumber,
                "unique_id.healthcare_number.medical_record_number" => ConfigEntityType.UniqueIdHealthcareNumberMedicalRecordNumber,
                "unique_id.unique_id_other" => ConfigEntityType.UniqueIdUniqueIdOther,
                "unique_id.vehicle_id" => ConfigEntityType.UniqueIdVehicleId,
                "url" => ConfigEntityType.Url,
                "username" => ConfigEntityType.Username,
                _ => null,
            };
        }
    }
}