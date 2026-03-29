//HintName: G.Models.ApiProjectsAwsCustomFunctionRetrieveResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deployment status of the Lambda function.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiProjectsAwsCustomFunctionRetrieveResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Active")]
        Active,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Inactive")]
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NotDeployed")]
        NotDeployed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NotFound")]
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiProjectsAwsCustomFunctionRetrieveResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiProjectsAwsCustomFunctionRetrieveResponseStatus value)
        {
            return value switch
            {
                ApiProjectsAwsCustomFunctionRetrieveResponseStatus.Active => "Active",
                ApiProjectsAwsCustomFunctionRetrieveResponseStatus.Error => "Error",
                ApiProjectsAwsCustomFunctionRetrieveResponseStatus.Failed => "Failed",
                ApiProjectsAwsCustomFunctionRetrieveResponseStatus.Inactive => "Inactive",
                ApiProjectsAwsCustomFunctionRetrieveResponseStatus.NotDeployed => "NotDeployed",
                ApiProjectsAwsCustomFunctionRetrieveResponseStatus.NotFound => "NotFound",
                ApiProjectsAwsCustomFunctionRetrieveResponseStatus.Pending => "Pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiProjectsAwsCustomFunctionRetrieveResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "Active" => ApiProjectsAwsCustomFunctionRetrieveResponseStatus.Active,
                "Error" => ApiProjectsAwsCustomFunctionRetrieveResponseStatus.Error,
                "Failed" => ApiProjectsAwsCustomFunctionRetrieveResponseStatus.Failed,
                "Inactive" => ApiProjectsAwsCustomFunctionRetrieveResponseStatus.Inactive,
                "NotDeployed" => ApiProjectsAwsCustomFunctionRetrieveResponseStatus.NotDeployed,
                "NotFound" => ApiProjectsAwsCustomFunctionRetrieveResponseStatus.NotFound,
                "Pending" => ApiProjectsAwsCustomFunctionRetrieveResponseStatus.Pending,
                _ => null,
            };
        }
    }
}