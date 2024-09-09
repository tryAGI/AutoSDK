//HintName: G.Models.SubstitutionPolicy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The replacement logic for detected PII, can be "entity_name" or "hash". See [PII redaction](https://www.assemblyai.com/docs/models/pii-redaction) for more details.
    /// </summary>
    public enum SubstitutionPolicy
    {
        /// <summary>
        /// 
        /// </summary>
        EntityName,
        /// <summary>
        /// 
        /// </summary>
        Hash,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubstitutionPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubstitutionPolicy value)
        {
            return value switch
            {
                SubstitutionPolicy.EntityName => "entity_name",
                SubstitutionPolicy.Hash => "hash",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubstitutionPolicy? ToEnum(string value)
        {
            return value switch
            {
                "entity_name" => SubstitutionPolicy.EntityName,
                "hash" => SubstitutionPolicy.Hash,
                _ => null,
            };
        }
    }
}