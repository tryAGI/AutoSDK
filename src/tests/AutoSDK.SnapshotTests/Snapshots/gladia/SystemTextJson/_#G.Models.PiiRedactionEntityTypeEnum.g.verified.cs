//HintName: G.Models.PiiRedactionEntityTypeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The entity types to redact
    /// </summary>
    public enum PiiRedactionEntityTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AccountNumber,
        /// <summary>
        /// 
        /// </summary>
        Age,
        /// <summary>
        /// 
        /// </summary>
        Appi,
        /// <summary>
        /// 
        /// </summary>
        AppiSensitive,
        /// <summary>
        /// 
        /// </summary>
        BankAccount,
        /// <summary>
        /// 
        /// </summary>
        BloodType,
        /// <summary>
        /// 
        /// </summary>
        Cci,
        /// <summary>
        /// 
        /// </summary>
        Condition,
        /// <summary>
        /// 
        /// </summary>
        CoreEntities,
        /// <summary>
        /// 
        /// </summary>
        CorporateAction,
        /// <summary>
        /// 
        /// </summary>
        Cpra,
        /// <summary>
        /// 
        /// </summary>
        CreditCard,
        /// <summary>
        /// 
        /// </summary>
        CreditCardExpiration,
        /// <summary>
        /// 
        /// </summary>
        Cvv,
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
        Day,
        /// <summary>
        /// 
        /// </summary>
        Dob,
        /// <summary>
        /// 
        /// </summary>
        Dose,
        /// <summary>
        /// 
        /// </summary>
        DriverLicense,
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
        Effect,
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
        FinancialMetric,
        /// <summary>
        /// 
        /// </summary>
        Gdpr,
        /// <summary>
        /// 
        /// </summary>
        GdprSensitive,
        /// <summary>
        /// 
        /// </summary>
        Gender,
        /// <summary>
        /// 
        /// </summary>
        HealthcareNumber,
        /// <summary>
        /// 
        /// </summary>
        HealthInformation,
        /// <summary>
        /// 
        /// </summary>
        HipaaSafeHarbor,
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
        Lidi,
        /// <summary>
        /// 
        /// </summary>
        Location,
        /// <summary>
        /// 
        /// </summary>
        LocationAddress,
        /// <summary>
        /// 
        /// </summary>
        LocationAddressStreet,
        /// <summary>
        /// 
        /// </summary>
        LocationCity,
        /// <summary>
        /// 
        /// </summary>
        LocationCoordinate,
        /// <summary>
        /// 
        /// </summary>
        LocationCountry,
        /// <summary>
        /// 
        /// </summary>
        LocationState,
        /// <summary>
        /// 
        /// </summary>
        LocationZip,
        /// <summary>
        /// 
        /// </summary>
        MaritalStatus,
        /// <summary>
        /// 
        /// </summary>
        MedicalCode,
        /// <summary>
        /// 
        /// </summary>
        MedicalProcess,
        /// <summary>
        /// 
        /// </summary>
        Money,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        NameFamily,
        /// <summary>
        /// 
        /// </summary>
        NameGiven,
        /// <summary>
        /// 
        /// </summary>
        NameMedicalProfessional,
        /// <summary>
        /// 
        /// </summary>
        NumericalExclPci,
        /// <summary>
        /// 
        /// </summary>
        NumericalPii,
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
        OrganizationId,
        /// <summary>
        /// 
        /// </summary>
        OrganizationMedicalFacility,
        /// <summary>
        /// 
        /// </summary>
        Origin,
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
        Pci,
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
        Product,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        QuebecPrivacyAct,
        /// <summary>
        /// 
        /// </summary>
        Religion,
        /// <summary>
        /// 
        /// </summary>
        RoutingNumber,
        /// <summary>
        /// 
        /// </summary>
        Sexuality,
        /// <summary>
        /// 
        /// </summary>
        Ssn,
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
        Trend,
        /// <summary>
        /// 
        /// </summary>
        Url,
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
        Year,
        /// <summary>
        /// 
        /// </summary>
        ZodiacSign,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PiiRedactionEntityTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PiiRedactionEntityTypeEnum value)
        {
            return value switch
            {
                PiiRedactionEntityTypeEnum.AccountNumber => "ACCOUNT_NUMBER",
                PiiRedactionEntityTypeEnum.Age => "AGE",
                PiiRedactionEntityTypeEnum.Appi => "APPI",
                PiiRedactionEntityTypeEnum.AppiSensitive => "APPI_SENSITIVE",
                PiiRedactionEntityTypeEnum.BankAccount => "BANK_ACCOUNT",
                PiiRedactionEntityTypeEnum.BloodType => "BLOOD_TYPE",
                PiiRedactionEntityTypeEnum.Cci => "CCI",
                PiiRedactionEntityTypeEnum.Condition => "CONDITION",
                PiiRedactionEntityTypeEnum.CoreEntities => "CORE_ENTITIES",
                PiiRedactionEntityTypeEnum.CorporateAction => "CORPORATE_ACTION",
                PiiRedactionEntityTypeEnum.Cpra => "CPRA",
                PiiRedactionEntityTypeEnum.CreditCard => "CREDIT_CARD",
                PiiRedactionEntityTypeEnum.CreditCardExpiration => "CREDIT_CARD_EXPIRATION",
                PiiRedactionEntityTypeEnum.Cvv => "CVV",
                PiiRedactionEntityTypeEnum.Date => "DATE",
                PiiRedactionEntityTypeEnum.DateInterval => "DATE_INTERVAL",
                PiiRedactionEntityTypeEnum.Day => "DAY",
                PiiRedactionEntityTypeEnum.Dob => "DOB",
                PiiRedactionEntityTypeEnum.Dose => "DOSE",
                PiiRedactionEntityTypeEnum.DriverLicense => "DRIVER_LICENSE",
                PiiRedactionEntityTypeEnum.Drug => "DRUG",
                PiiRedactionEntityTypeEnum.Duration => "DURATION",
                PiiRedactionEntityTypeEnum.Effect => "EFFECT",
                PiiRedactionEntityTypeEnum.EmailAddress => "EMAIL_ADDRESS",
                PiiRedactionEntityTypeEnum.Event => "EVENT",
                PiiRedactionEntityTypeEnum.Filename => "FILENAME",
                PiiRedactionEntityTypeEnum.FinancialMetric => "FINANCIAL_METRIC",
                PiiRedactionEntityTypeEnum.Gdpr => "GDPR",
                PiiRedactionEntityTypeEnum.GdprSensitive => "GDPR_SENSITIVE",
                PiiRedactionEntityTypeEnum.Gender => "GENDER",
                PiiRedactionEntityTypeEnum.HealthcareNumber => "HEALTHCARE_NUMBER",
                PiiRedactionEntityTypeEnum.HealthInformation => "HEALTH_INFORMATION",
                PiiRedactionEntityTypeEnum.HipaaSafeHarbor => "HIPAA_SAFE_HARBOR",
                PiiRedactionEntityTypeEnum.Injury => "INJURY",
                PiiRedactionEntityTypeEnum.IpAddress => "IP_ADDRESS",
                PiiRedactionEntityTypeEnum.Language => "LANGUAGE",
                PiiRedactionEntityTypeEnum.Lidi => "LIDI",
                PiiRedactionEntityTypeEnum.Location => "LOCATION",
                PiiRedactionEntityTypeEnum.LocationAddress => "LOCATION_ADDRESS",
                PiiRedactionEntityTypeEnum.LocationAddressStreet => "LOCATION_ADDRESS_STREET",
                PiiRedactionEntityTypeEnum.LocationCity => "LOCATION_CITY",
                PiiRedactionEntityTypeEnum.LocationCoordinate => "LOCATION_COORDINATE",
                PiiRedactionEntityTypeEnum.LocationCountry => "LOCATION_COUNTRY",
                PiiRedactionEntityTypeEnum.LocationState => "LOCATION_STATE",
                PiiRedactionEntityTypeEnum.LocationZip => "LOCATION_ZIP",
                PiiRedactionEntityTypeEnum.MaritalStatus => "MARITAL_STATUS",
                PiiRedactionEntityTypeEnum.MedicalCode => "MEDICAL_CODE",
                PiiRedactionEntityTypeEnum.MedicalProcess => "MEDICAL_PROCESS",
                PiiRedactionEntityTypeEnum.Money => "MONEY",
                PiiRedactionEntityTypeEnum.Month => "MONTH",
                PiiRedactionEntityTypeEnum.Name => "NAME",
                PiiRedactionEntityTypeEnum.NameFamily => "NAME_FAMILY",
                PiiRedactionEntityTypeEnum.NameGiven => "NAME_GIVEN",
                PiiRedactionEntityTypeEnum.NameMedicalProfessional => "NAME_MEDICAL_PROFESSIONAL",
                PiiRedactionEntityTypeEnum.NumericalExclPci => "NUMERICAL_EXCL_PCI",
                PiiRedactionEntityTypeEnum.NumericalPii => "NUMERICAL_PII",
                PiiRedactionEntityTypeEnum.Occupation => "OCCUPATION",
                PiiRedactionEntityTypeEnum.Organization => "ORGANIZATION",
                PiiRedactionEntityTypeEnum.OrganizationId => "ORGANIZATION_ID",
                PiiRedactionEntityTypeEnum.OrganizationMedicalFacility => "ORGANIZATION_MEDICAL_FACILITY",
                PiiRedactionEntityTypeEnum.Origin => "ORIGIN",
                PiiRedactionEntityTypeEnum.PassportNumber => "PASSPORT_NUMBER",
                PiiRedactionEntityTypeEnum.Password => "PASSWORD",
                PiiRedactionEntityTypeEnum.Pci => "PCI",
                PiiRedactionEntityTypeEnum.PhoneNumber => "PHONE_NUMBER",
                PiiRedactionEntityTypeEnum.PhysicalAttribute => "PHYSICAL_ATTRIBUTE",
                PiiRedactionEntityTypeEnum.PoliticalAffiliation => "POLITICAL_AFFILIATION",
                PiiRedactionEntityTypeEnum.Product => "PRODUCT",
                PiiRedactionEntityTypeEnum.Project => "PROJECT",
                PiiRedactionEntityTypeEnum.QuebecPrivacyAct => "QUEBEC_PRIVACY_ACT",
                PiiRedactionEntityTypeEnum.Religion => "RELIGION",
                PiiRedactionEntityTypeEnum.RoutingNumber => "ROUTING_NUMBER",
                PiiRedactionEntityTypeEnum.Sexuality => "SEXUALITY",
                PiiRedactionEntityTypeEnum.Ssn => "SSN",
                PiiRedactionEntityTypeEnum.Statistics => "STATISTICS",
                PiiRedactionEntityTypeEnum.Time => "TIME",
                PiiRedactionEntityTypeEnum.Trend => "TREND",
                PiiRedactionEntityTypeEnum.Url => "URL",
                PiiRedactionEntityTypeEnum.Username => "USERNAME",
                PiiRedactionEntityTypeEnum.VehicleId => "VEHICLE_ID",
                PiiRedactionEntityTypeEnum.Year => "YEAR",
                PiiRedactionEntityTypeEnum.ZodiacSign => "ZODIAC_SIGN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PiiRedactionEntityTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "ACCOUNT_NUMBER" => PiiRedactionEntityTypeEnum.AccountNumber,
                "AGE" => PiiRedactionEntityTypeEnum.Age,
                "APPI" => PiiRedactionEntityTypeEnum.Appi,
                "APPI_SENSITIVE" => PiiRedactionEntityTypeEnum.AppiSensitive,
                "BANK_ACCOUNT" => PiiRedactionEntityTypeEnum.BankAccount,
                "BLOOD_TYPE" => PiiRedactionEntityTypeEnum.BloodType,
                "CCI" => PiiRedactionEntityTypeEnum.Cci,
                "CONDITION" => PiiRedactionEntityTypeEnum.Condition,
                "CORE_ENTITIES" => PiiRedactionEntityTypeEnum.CoreEntities,
                "CORPORATE_ACTION" => PiiRedactionEntityTypeEnum.CorporateAction,
                "CPRA" => PiiRedactionEntityTypeEnum.Cpra,
                "CREDIT_CARD" => PiiRedactionEntityTypeEnum.CreditCard,
                "CREDIT_CARD_EXPIRATION" => PiiRedactionEntityTypeEnum.CreditCardExpiration,
                "CVV" => PiiRedactionEntityTypeEnum.Cvv,
                "DATE" => PiiRedactionEntityTypeEnum.Date,
                "DATE_INTERVAL" => PiiRedactionEntityTypeEnum.DateInterval,
                "DAY" => PiiRedactionEntityTypeEnum.Day,
                "DOB" => PiiRedactionEntityTypeEnum.Dob,
                "DOSE" => PiiRedactionEntityTypeEnum.Dose,
                "DRIVER_LICENSE" => PiiRedactionEntityTypeEnum.DriverLicense,
                "DRUG" => PiiRedactionEntityTypeEnum.Drug,
                "DURATION" => PiiRedactionEntityTypeEnum.Duration,
                "EFFECT" => PiiRedactionEntityTypeEnum.Effect,
                "EMAIL_ADDRESS" => PiiRedactionEntityTypeEnum.EmailAddress,
                "EVENT" => PiiRedactionEntityTypeEnum.Event,
                "FILENAME" => PiiRedactionEntityTypeEnum.Filename,
                "FINANCIAL_METRIC" => PiiRedactionEntityTypeEnum.FinancialMetric,
                "GDPR" => PiiRedactionEntityTypeEnum.Gdpr,
                "GDPR_SENSITIVE" => PiiRedactionEntityTypeEnum.GdprSensitive,
                "GENDER" => PiiRedactionEntityTypeEnum.Gender,
                "HEALTHCARE_NUMBER" => PiiRedactionEntityTypeEnum.HealthcareNumber,
                "HEALTH_INFORMATION" => PiiRedactionEntityTypeEnum.HealthInformation,
                "HIPAA_SAFE_HARBOR" => PiiRedactionEntityTypeEnum.HipaaSafeHarbor,
                "INJURY" => PiiRedactionEntityTypeEnum.Injury,
                "IP_ADDRESS" => PiiRedactionEntityTypeEnum.IpAddress,
                "LANGUAGE" => PiiRedactionEntityTypeEnum.Language,
                "LIDI" => PiiRedactionEntityTypeEnum.Lidi,
                "LOCATION" => PiiRedactionEntityTypeEnum.Location,
                "LOCATION_ADDRESS" => PiiRedactionEntityTypeEnum.LocationAddress,
                "LOCATION_ADDRESS_STREET" => PiiRedactionEntityTypeEnum.LocationAddressStreet,
                "LOCATION_CITY" => PiiRedactionEntityTypeEnum.LocationCity,
                "LOCATION_COORDINATE" => PiiRedactionEntityTypeEnum.LocationCoordinate,
                "LOCATION_COUNTRY" => PiiRedactionEntityTypeEnum.LocationCountry,
                "LOCATION_STATE" => PiiRedactionEntityTypeEnum.LocationState,
                "LOCATION_ZIP" => PiiRedactionEntityTypeEnum.LocationZip,
                "MARITAL_STATUS" => PiiRedactionEntityTypeEnum.MaritalStatus,
                "MEDICAL_CODE" => PiiRedactionEntityTypeEnum.MedicalCode,
                "MEDICAL_PROCESS" => PiiRedactionEntityTypeEnum.MedicalProcess,
                "MONEY" => PiiRedactionEntityTypeEnum.Money,
                "MONTH" => PiiRedactionEntityTypeEnum.Month,
                "NAME" => PiiRedactionEntityTypeEnum.Name,
                "NAME_FAMILY" => PiiRedactionEntityTypeEnum.NameFamily,
                "NAME_GIVEN" => PiiRedactionEntityTypeEnum.NameGiven,
                "NAME_MEDICAL_PROFESSIONAL" => PiiRedactionEntityTypeEnum.NameMedicalProfessional,
                "NUMERICAL_EXCL_PCI" => PiiRedactionEntityTypeEnum.NumericalExclPci,
                "NUMERICAL_PII" => PiiRedactionEntityTypeEnum.NumericalPii,
                "OCCUPATION" => PiiRedactionEntityTypeEnum.Occupation,
                "ORGANIZATION" => PiiRedactionEntityTypeEnum.Organization,
                "ORGANIZATION_ID" => PiiRedactionEntityTypeEnum.OrganizationId,
                "ORGANIZATION_MEDICAL_FACILITY" => PiiRedactionEntityTypeEnum.OrganizationMedicalFacility,
                "ORIGIN" => PiiRedactionEntityTypeEnum.Origin,
                "PASSPORT_NUMBER" => PiiRedactionEntityTypeEnum.PassportNumber,
                "PASSWORD" => PiiRedactionEntityTypeEnum.Password,
                "PCI" => PiiRedactionEntityTypeEnum.Pci,
                "PHONE_NUMBER" => PiiRedactionEntityTypeEnum.PhoneNumber,
                "PHYSICAL_ATTRIBUTE" => PiiRedactionEntityTypeEnum.PhysicalAttribute,
                "POLITICAL_AFFILIATION" => PiiRedactionEntityTypeEnum.PoliticalAffiliation,
                "PRODUCT" => PiiRedactionEntityTypeEnum.Product,
                "PROJECT" => PiiRedactionEntityTypeEnum.Project,
                "QUEBEC_PRIVACY_ACT" => PiiRedactionEntityTypeEnum.QuebecPrivacyAct,
                "RELIGION" => PiiRedactionEntityTypeEnum.Religion,
                "ROUTING_NUMBER" => PiiRedactionEntityTypeEnum.RoutingNumber,
                "SEXUALITY" => PiiRedactionEntityTypeEnum.Sexuality,
                "SSN" => PiiRedactionEntityTypeEnum.Ssn,
                "STATISTICS" => PiiRedactionEntityTypeEnum.Statistics,
                "TIME" => PiiRedactionEntityTypeEnum.Time,
                "TREND" => PiiRedactionEntityTypeEnum.Trend,
                "URL" => PiiRedactionEntityTypeEnum.Url,
                "USERNAME" => PiiRedactionEntityTypeEnum.Username,
                "VEHICLE_ID" => PiiRedactionEntityTypeEnum.VehicleId,
                "YEAR" => PiiRedactionEntityTypeEnum.Year,
                "ZODIAC_SIGN" => PiiRedactionEntityTypeEnum.ZodiacSign,
                _ => null,
            };
        }
    }
}