//HintName: G.Models.ObjectReferenceNullishObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the object the event is originating from.
    /// </summary>
    public enum ObjectReferenceNullishObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        ProjectLogs,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        PromptSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectReferenceNullishObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectReferenceNullishObjectType value)
        {
            return value switch
            {
                ObjectReferenceNullishObjectType.Dataset => "dataset",
                ObjectReferenceNullishObjectType.Experiment => "experiment",
                ObjectReferenceNullishObjectType.Function => "function",
                ObjectReferenceNullishObjectType.ProjectLogs => "project_logs",
                ObjectReferenceNullishObjectType.Prompt => "prompt",
                ObjectReferenceNullishObjectType.PromptSession => "prompt_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectReferenceNullishObjectType? ToEnum(string value)
        {
            return value switch
            {
                "dataset" => ObjectReferenceNullishObjectType.Dataset,
                "experiment" => ObjectReferenceNullishObjectType.Experiment,
                "function" => ObjectReferenceNullishObjectType.Function,
                "project_logs" => ObjectReferenceNullishObjectType.ProjectLogs,
                "prompt" => ObjectReferenceNullishObjectType.Prompt,
                "prompt_session" => ObjectReferenceNullishObjectType.PromptSession,
                _ => null,
            };
        }
    }
}