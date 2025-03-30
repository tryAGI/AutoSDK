//HintName: G.Models.DatasetTransformationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for dataset data types.
    /// </summary>
    public enum DatasetTransformationType
    {
        /// <summary>
        /// 
        /// </summary>
        RemoveSystemMessages,
        /// <summary>
        /// 
        /// </summary>
        ConvertToOpenaiMessage,
        /// <summary>
        /// 
        /// </summary>
        ConvertToOpenaiTool,
        /// <summary>
        /// 
        /// </summary>
        RemoveExtraFields,
        /// <summary>
        /// 
        /// </summary>
        ExtractToolsFromRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DatasetTransformationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DatasetTransformationType value)
        {
            return value switch
            {
                DatasetTransformationType.RemoveSystemMessages => "remove_system_messages",
                DatasetTransformationType.ConvertToOpenaiMessage => "convert_to_openai_message",
                DatasetTransformationType.ConvertToOpenaiTool => "convert_to_openai_tool",
                DatasetTransformationType.RemoveExtraFields => "remove_extra_fields",
                DatasetTransformationType.ExtractToolsFromRun => "extract_tools_from_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DatasetTransformationType? ToEnum(string value)
        {
            return value switch
            {
                "remove_system_messages" => DatasetTransformationType.RemoveSystemMessages,
                "convert_to_openai_message" => DatasetTransformationType.ConvertToOpenaiMessage,
                "convert_to_openai_tool" => DatasetTransformationType.ConvertToOpenaiTool,
                "remove_extra_fields" => DatasetTransformationType.RemoveExtraFields,
                "extract_tools_from_run" => DatasetTransformationType.ExtractToolsFromRun,
                _ => null,
            };
        }
    }
}