//HintName: G.Models.UsageVectorStoresResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageVectorStoresResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageVectorStoresResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageVectorStoresResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageVectorStoresResultObject value)
        {
            return value switch
            {
                UsageVectorStoresResultObject.OrganizationUsageVectorStoresResult => "organization.usage.vector_stores.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageVectorStoresResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.vector_stores.result" => UsageVectorStoresResultObject.OrganizationUsageVectorStoresResult,
                _ => null,
            };
        }
    }
}