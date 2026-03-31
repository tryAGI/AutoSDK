//HintName: G.Models.DataSourceAuthParamsVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataSourceAuthParamsVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataSourceAuthParamsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataSourceAuthParamsVariant1DiscriminatorType value)
        {
            return value switch
            {
                DataSourceAuthParamsVariant1DiscriminatorType.ApiKey => "api_key",
                DataSourceAuthParamsVariant1DiscriminatorType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataSourceAuthParamsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => DataSourceAuthParamsVariant1DiscriminatorType.ApiKey,
                "oauth2" => DataSourceAuthParamsVariant1DiscriminatorType.Oauth2,
                _ => null,
            };
        }
    }
}