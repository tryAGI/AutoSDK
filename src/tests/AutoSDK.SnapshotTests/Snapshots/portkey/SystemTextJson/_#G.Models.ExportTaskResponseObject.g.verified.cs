//HintName: G.Models.ExportTaskResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object
    /// </summary>
    public enum ExportTaskResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        Export,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportTaskResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportTaskResponseObject value)
        {
            return value switch
            {
                ExportTaskResponseObject.Export => "export",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportTaskResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "export" => ExportTaskResponseObject.Export,
                _ => null,
            };
        }
    }
}