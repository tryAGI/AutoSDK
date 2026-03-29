//HintName: G.Models.UpdateExportResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object
    /// </summary>
    public enum UpdateExportResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        Export,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateExportResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateExportResponseObject value)
        {
            return value switch
            {
                UpdateExportResponseObject.Export => "export",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateExportResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "export" => UpdateExportResponseObject.Export,
                _ => null,
            };
        }
    }
}