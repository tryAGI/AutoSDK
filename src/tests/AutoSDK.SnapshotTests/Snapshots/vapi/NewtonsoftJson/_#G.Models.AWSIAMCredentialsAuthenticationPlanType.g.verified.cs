//HintName: G.Models.AWSIAMCredentialsAuthenticationPlanType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AWSIAMCredentialsAuthenticationPlanType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aws-iam")]
        AwsIam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AWSIAMCredentialsAuthenticationPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AWSIAMCredentialsAuthenticationPlanType value)
        {
            return value switch
            {
                AWSIAMCredentialsAuthenticationPlanType.AwsIam => "aws-iam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AWSIAMCredentialsAuthenticationPlanType? ToEnum(string value)
        {
            return value switch
            {
                "aws-iam" => AWSIAMCredentialsAuthenticationPlanType.AwsIam,
                _ => null,
            };
        }
    }
}