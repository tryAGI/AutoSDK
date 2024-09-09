//HintName: G.Models.TenantShareDatasetTokenType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TenantShareDatasetTokenType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TenantShareDatasetTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TenantShareDatasetTokenType value)
        {
            return value switch
            {
                TenantShareDatasetTokenType.Dataset => "dataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TenantShareDatasetTokenType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => TenantShareDatasetTokenType.Dataset,
                _ => null,
            };
        }
    }
}