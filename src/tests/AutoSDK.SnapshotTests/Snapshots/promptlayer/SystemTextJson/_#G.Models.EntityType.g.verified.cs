//HintName: G.Models.EntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of entity. SNIPPET is a pseudo-entity type representing completion-type prompts.
    /// </summary>
    public enum EntityType
    {
        /// <summary>
        /// 
        /// </summary>
        AbTest,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Folder,
        /// <summary>
        /// 
        /// </summary>
        InputVariableSet,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Report,
        /// <summary>
        /// 
        /// </summary>
        Snippet,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EntityType value)
        {
            return value switch
            {
                EntityType.AbTest => "AB_TEST",
                EntityType.Dataset => "DATASET",
                EntityType.Folder => "FOLDER",
                EntityType.InputVariableSet => "INPUT_VARIABLE_SET",
                EntityType.Prompt => "PROMPT",
                EntityType.Report => "REPORT",
                EntityType.Snippet => "SNIPPET",
                EntityType.Workflow => "WORKFLOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EntityType? ToEnum(string value)
        {
            return value switch
            {
                "AB_TEST" => EntityType.AbTest,
                "DATASET" => EntityType.Dataset,
                "FOLDER" => EntityType.Folder,
                "INPUT_VARIABLE_SET" => EntityType.InputVariableSet,
                "PROMPT" => EntityType.Prompt,
                "REPORT" => EntityType.Report,
                "SNIPPET" => EntityType.Snippet,
                "WORKFLOW" => EntityType.Workflow,
                _ => null,
            };
        }
    }
}