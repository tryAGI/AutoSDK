//HintName: G.Models.ExportChatDTOFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the format of the export.<br/>
    /// @default csv<br/>
    /// Default Value: csv
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExportChatDTOFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="csv")]
        Csv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportChatDTOFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportChatDTOFormat value)
        {
            return value switch
            {
                ExportChatDTOFormat.Csv => "csv",
                ExportChatDTOFormat.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportChatDTOFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => ExportChatDTOFormat.Csv,
                "json" => ExportChatDTOFormat.Json,
                _ => null,
            };
        }
    }
}