//HintName: G.Models.CompanyEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Entity type discriminator.<br/>
    /// Example: company
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompanyEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="company")]
        Company,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompanyEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompanyEntityType value)
        {
            return value switch
            {
                CompanyEntityType.Company => "company",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompanyEntityType? ToEnum(string value)
        {
            return value switch
            {
                "company" => CompanyEntityType.Company,
                _ => null,
            };
        }
    }
}