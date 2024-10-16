//HintName: G.Models.TenantShareTokensResponseEntitieDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TenantShareTokensResponseEntitieDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Run,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TenantShareTokensResponseEntitieDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TenantShareTokensResponseEntitieDiscriminatorType value)
        {
            return value switch
            {
                TenantShareTokensResponseEntitieDiscriminatorType.Dataset => "dataset",
                TenantShareTokensResponseEntitieDiscriminatorType.Run => "run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TenantShareTokensResponseEntitieDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => TenantShareTokensResponseEntitieDiscriminatorType.Dataset,
                "run" => TenantShareTokensResponseEntitieDiscriminatorType.Run,
                _ => null,
            };
        }
    }
}