//HintName: G.Models.GetOrCreateRagIndexesResponseDiscriminatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetOrCreateRagIndexesResponseDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrCreateRagIndexesResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrCreateRagIndexesResponseDiscriminatorStatus value)
        {
            return value switch
            {
                GetOrCreateRagIndexesResponseDiscriminatorStatus.Failure => "failure",
                GetOrCreateRagIndexesResponseDiscriminatorStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrCreateRagIndexesResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => GetOrCreateRagIndexesResponseDiscriminatorStatus.Failure,
                "success" => GetOrCreateRagIndexesResponseDiscriminatorStatus.Success,
                _ => null,
            };
        }
    }
}