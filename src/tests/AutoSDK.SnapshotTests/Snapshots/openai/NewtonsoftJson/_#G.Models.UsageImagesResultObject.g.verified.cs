//HintName: G.Models.UsageImagesResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageImagesResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.images.result")]
        OrganizationUsageImagesResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageImagesResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageImagesResultObject value)
        {
            return value switch
            {
                UsageImagesResultObject.OrganizationUsageImagesResult => "organization.usage.images.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageImagesResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.images.result" => UsageImagesResultObject.OrganizationUsageImagesResult,
                _ => null,
            };
        }
    }
}