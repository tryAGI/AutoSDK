//HintName: G.Models.ImportJobStatusResultDiscriminatorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImportJobStatusResultDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partial")]
        Partial,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportJobStatusResultDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportJobStatusResultDiscriminatorStatus value)
        {
            return value switch
            {
                ImportJobStatusResultDiscriminatorStatus.Error => "error",
                ImportJobStatusResultDiscriminatorStatus.Partial => "partial",
                ImportJobStatusResultDiscriminatorStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportJobStatusResultDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ImportJobStatusResultDiscriminatorStatus.Error,
                "partial" => ImportJobStatusResultDiscriminatorStatus.Partial,
                "success" => ImportJobStatusResultDiscriminatorStatus.Success,
                _ => null,
            };
        }
    }
}