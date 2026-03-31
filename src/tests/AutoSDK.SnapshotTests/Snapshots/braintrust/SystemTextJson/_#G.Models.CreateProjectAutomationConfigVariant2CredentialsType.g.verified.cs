//HintName: G.Models.CreateProjectAutomationConfigVariant2CredentialsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateProjectAutomationConfigVariant2CredentialsType
    {
        /// <summary>
        /// 
        /// </summary>
        AwsIam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectAutomationConfigVariant2CredentialsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant2CredentialsType value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant2CredentialsType.AwsIam => "aws_iam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant2CredentialsType? ToEnum(string value)
        {
            return value switch
            {
                "aws_iam" => CreateProjectAutomationConfigVariant2CredentialsType.AwsIam,
                _ => null,
            };
        }
    }
}