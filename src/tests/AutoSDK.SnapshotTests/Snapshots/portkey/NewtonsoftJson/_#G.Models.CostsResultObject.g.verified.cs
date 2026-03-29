//HintName: G.Models.CostsResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CostsResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.costs.result")]
        OrganizationCostsResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CostsResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CostsResultObject value)
        {
            return value switch
            {
                CostsResultObject.OrganizationCostsResult => "organization.costs.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CostsResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.costs.result" => CostsResultObject.OrganizationCostsResult,
                _ => null,
            };
        }
    }
}