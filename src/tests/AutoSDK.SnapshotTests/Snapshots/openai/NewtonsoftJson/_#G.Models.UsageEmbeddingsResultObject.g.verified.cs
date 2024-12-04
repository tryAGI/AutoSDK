//HintName: G.Models.UsageEmbeddingsResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageEmbeddingsResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.embeddings.result")]
        OrganizationUsageEmbeddingsResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageEmbeddingsResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageEmbeddingsResultObject value)
        {
            return value switch
            {
                UsageEmbeddingsResultObject.OrganizationUsageEmbeddingsResult => "organization.usage.embeddings.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageEmbeddingsResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.embeddings.result" => UsageEmbeddingsResultObject.OrganizationUsageEmbeddingsResult,
                _ => null,
            };
        }
    }
}