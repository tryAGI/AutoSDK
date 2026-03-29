//HintName: G.Models.ComprehendMedicalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ComprehendMedicalType
    {
        /// <summary>
        /// 
        /// </summary>
        Entities,
        /// <summary>
        /// 
        /// </summary>
        Icd10Cm,
        /// <summary>
        /// 
        /// </summary>
        RxNorm,
        /// <summary>
        /// 
        /// </summary>
        SnomedCt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComprehendMedicalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComprehendMedicalType value)
        {
            return value switch
            {
                ComprehendMedicalType.Entities => "Entities",
                ComprehendMedicalType.Icd10Cm => "ICD-10-CM",
                ComprehendMedicalType.RxNorm => "RxNorm",
                ComprehendMedicalType.SnomedCt => "SNOMED CT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComprehendMedicalType? ToEnum(string value)
        {
            return value switch
            {
                "Entities" => ComprehendMedicalType.Entities,
                "ICD-10-CM" => ComprehendMedicalType.Icd10Cm,
                "RxNorm" => ComprehendMedicalType.RxNorm,
                "SNOMED CT" => ComprehendMedicalType.SnomedCt,
                _ => null,
            };
        }
    }
}