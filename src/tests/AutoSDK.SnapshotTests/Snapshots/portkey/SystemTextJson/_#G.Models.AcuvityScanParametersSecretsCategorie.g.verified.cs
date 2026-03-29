//HintName: G.Models.AcuvityScanParametersSecretsCategorie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AcuvityScanParametersSecretsCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        AwsSecretKey,
        /// <summary>
        /// 
        /// </summary>
        Credentials,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Jwt,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        PrivateKey,
        /// <summary>
        /// 
        /// </summary>
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