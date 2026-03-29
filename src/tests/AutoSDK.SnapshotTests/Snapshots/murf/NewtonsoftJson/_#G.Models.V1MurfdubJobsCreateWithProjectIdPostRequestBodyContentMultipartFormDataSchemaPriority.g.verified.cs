//HintName: G.Models.V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Priority of the job. Allowed values: LOW, NORMAL, HIGH
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority
    {
        /// <summary>
        /// LOW, NORMAL, HIGH
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HIGH")]
        High,
        /// <summary>
        /// LOW, NORMAL, HIGH
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LOW")]
        Low,
        /// <summary>
        /// LOW, NORMAL, HIGH
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NORMAL")]
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority value)
        {
            return value switch
            {
                V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority.High => "HIGH",
                V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority.Low => "LOW",
                V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority.Normal => "NORMAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority.High,
                "LOW" => V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority.Low,
                "NORMAL" => V1MurfdubJobsCreateWithProjectIdPostRequestBodyContentMultipartFormDataSchemaPriority.Normal,
                _ => null,
            };
        }
    }
}