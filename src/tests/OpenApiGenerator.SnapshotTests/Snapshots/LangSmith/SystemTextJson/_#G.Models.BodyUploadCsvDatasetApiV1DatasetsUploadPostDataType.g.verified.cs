//HintName: G.Models.BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for dataset data types.
    /// </summary>
    public enum BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Kv,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyUploadCsvDatasetApiV1DatasetsUploadPostDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType value)
        {
            return value switch
            {
                BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType.Kv => "kv",
                BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType.Llm => "llm",
                BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType? ToEnum(string value)
        {
            return value switch
            {
                "kv" => BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType.Kv,
                "llm" => BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType.Llm,
                "chat" => BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType.Chat,
                _ => null,
            };
        }
    }
}