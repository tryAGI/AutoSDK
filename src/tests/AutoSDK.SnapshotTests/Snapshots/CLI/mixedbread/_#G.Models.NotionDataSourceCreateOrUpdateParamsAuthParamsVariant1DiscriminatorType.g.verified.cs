//HintName: G.Models.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType
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
    public static class NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType value)
        {
            return value switch
            {
                NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.ApiKey => "api_key",
                NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.ApiKey,
                "oauth2" => NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.Oauth2,
                _ => null,
            };
        }
    }
}