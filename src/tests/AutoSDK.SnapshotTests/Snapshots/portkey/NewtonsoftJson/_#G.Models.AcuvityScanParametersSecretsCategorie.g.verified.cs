//HintName: G.Models.AcuvityScanParametersSecretsCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AcuvityScanParametersSecretsCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aws_secret_key")]
        AwsSecretKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credentials")]
        Credentials,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="github")]
        Github,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jwt")]
        Jwt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private_key")]
        PrivateKey,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stripe")]
        Stripe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AcuvityScanParametersSecretsCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AcuvityScanParametersSecretsCategorie value)
        {
            return value switch
            {
                AcuvityScanParametersSecretsCategorie.AwsSecretKey => "aws_secret_key",
                AcuvityScanParametersSecretsCategorie.Credentials => "credentials",
                AcuvityScanParametersSecretsCategorie.Github => "github",
                AcuvityScanParametersSecretsCategorie.Jwt => "jwt",
                AcuvityScanParametersSecretsCategorie.Openai => "openai",
                AcuvityScanParametersSecretsCategorie.PrivateKey => "private_key",
                AcuvityScanParametersSecretsCategorie.Stripe => "stripe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AcuvityScanParametersSecretsCategorie? ToEnum(string value)
        {
            return value switch
            {
                "aws_secret_key" => AcuvityScanParametersSecretsCategorie.AwsSecretKey,
                "credentials" => AcuvityScanParametersSecretsCategorie.Credentials,
                "github" => AcuvityScanParametersSecretsCategorie.Github,
                "jwt" => AcuvityScanParametersSecretsCategorie.Jwt,
                "openai" => AcuvityScanParametersSecretsCategorie.Openai,
                "private_key" => AcuvityScanParametersSecretsCategorie.PrivateKey,
                "stripe" => AcuvityScanParametersSecretsCategorie.Stripe,
                _ => null,
            };
        }
    }
}