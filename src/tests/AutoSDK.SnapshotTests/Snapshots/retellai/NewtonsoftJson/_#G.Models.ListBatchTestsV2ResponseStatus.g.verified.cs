//HintName: G.Models.ListBatchTestsV2ResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListBatchTestsV2ResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListBatchTestsV2ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListBatchTestsV2ResponseStatus value)
        {
            return value switch
            {
                ListBatchTestsV2ResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListBatchTestsV2ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ListBatchTestsV2ResponseStatus.Error,
                _ => null,
            };
        }
    }
}