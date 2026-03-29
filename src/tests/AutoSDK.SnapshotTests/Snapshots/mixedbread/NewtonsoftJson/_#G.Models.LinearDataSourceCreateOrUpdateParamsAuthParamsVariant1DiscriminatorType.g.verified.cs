//HintName: G.Models.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="oauth2")]
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType value)
        {
            return value switch
            {
                LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "oauth2" => LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.Oauth2,
                _ => null,
            };
        }
    }
}