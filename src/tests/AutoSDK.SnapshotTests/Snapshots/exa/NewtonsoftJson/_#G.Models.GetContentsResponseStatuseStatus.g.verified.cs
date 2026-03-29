//HintName: G.Models.GetContentsResponseStatuseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status of the content fetch operation<br/>
    /// Example: success
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetContentsResponseStatuseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetContentsResponseStatuseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetContentsResponseStatuseStatus value)
        {
            return value switch
            {
                GetContentsResponseStatuseStatus.Error => "error",
                GetContentsResponseStatuseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetContentsResponseStatuseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => GetContentsResponseStatuseStatus.Error,
                "success" => GetContentsResponseStatuseStatus.Success,
                _ => null,
            };
        }
    }
}