//HintName: G.Models.ImportSuccessResultStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// - success: All media imported successfully<br/>
    /// - partial: Some media imported successfully, some failed<br/>
    /// Example: success
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImportSuccessResultStatus
    {
        /// <summary>
        /// Some media imported successfully, some failed
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partial")]
        Partial,
        /// <summary>
        /// All media imported successfully
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportSuccessResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportSuccessResultStatus value)
        {
            return value switch
            {
                ImportSuccessResultStatus.Partial => "partial",
                ImportSuccessResultStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportSuccessResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "partial" => ImportSuccessResultStatus.Partial,
                "success" => ImportSuccessResultStatus.Success,
                _ => null,
            };
        }
    }
}