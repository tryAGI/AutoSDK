//HintName: G.Models.ProjectAutomationConfigVariant2CredentialsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectAutomationConfigVariant2CredentialsType
    {
        /// <summary>
        /// 
        /// </summary>
        AwsIam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectAutomationConfigVariant2CredentialsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectAutomationConfigVariant2CredentialsType value)
        {
            return value switch
            {
                ProjectAutomationConfigVariant2CredentialsType.AwsIam => "aws_iam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectAutomationConfigVariant2CredentialsType? ToEnum(string value)
        {
            return value switch
            {
                "aws_iam" => ProjectAutomationConfigVariant2CredentialsType.AwsIam,
                _ => null,
            };
        }
    }
}