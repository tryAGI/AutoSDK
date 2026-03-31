//HintName: G.Models.PatchProjectAutomationConfigVariant2CredentialsType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchProjectAutomationConfigVariant2CredentialsType
    {
        /// <summary>
        /// 
        /// </summary>
        AwsIam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant2CredentialsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant2CredentialsType value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant2CredentialsType.AwsIam => "aws_iam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant2CredentialsType? ToEnum(string value)
        {
            return value switch
            {
                "aws_iam" => PatchProjectAutomationConfigVariant2CredentialsType.AwsIam,
                _ => null,
            };
        }
    }
}