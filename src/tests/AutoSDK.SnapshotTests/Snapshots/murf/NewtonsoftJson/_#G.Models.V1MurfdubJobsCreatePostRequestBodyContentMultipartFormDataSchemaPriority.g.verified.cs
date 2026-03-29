//HintName: G.Models.V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Priority of the job. Allowed values: LOW, NORMAL, HIGH
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority
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
    public static class V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority value)
        {
            return value switch
            {
                V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority.High => "HIGH",
                V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority.Low => "LOW",
                V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority.Normal => "NORMAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority.High,
                "LOW" => V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority.Low,
                "NORMAL" => V1MurfdubJobsCreatePostRequestBodyContentMultipartFormDataSchemaPriority.Normal,
                _ => null,
            };
        }
    }
}