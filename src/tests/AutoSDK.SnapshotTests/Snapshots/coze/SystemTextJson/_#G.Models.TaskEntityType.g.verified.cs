//HintName: G.Models.TaskEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TaskEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Database,
        /// <summary>
        /// 
        /// </summary>
        Imageflow,
        /// <summary>
        /// 
        /// </summary>
        Knowledge,
        /// <summary>
        /// 
        /// </summary>
        Plugin,
        /// <summary>
        /// 
        /// </summary>
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        Shortcut,
        /// <summary>
        /// 
        /// </summary>
        Trigger,
        /// <summary>
        /// 
        /// </summary>
        Ui,
        /// <summary>
        /// 
        /// </summary>
        Variable,
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskEntityType value)
        {
            return value switch
            {
                TaskEntityType.App => "app",
                TaskEntityType.Bot => "bot",
                TaskEntityType.Database => "database",
                TaskEntityType.Imageflow => "imageflow",
                TaskEntityType.Knowledge => "knowledge",
                TaskEntityType.Plugin => "plugin",
                TaskEntityType.Prompt => "prompt",
                TaskEntityType.Shortcut => "shortcut",
                TaskEntityType.Trigger => "trigger",
                TaskEntityType.Ui => "ui",
                TaskEntityType.Variable => "variable",
                TaskEntityType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskEntityType? ToEnum(string value)
        {
            return value switch
            {
                "app" => TaskEntityType.App,
                "bot" => TaskEntityType.Bot,
                "database" => TaskEntityType.Database,
                "imageflow" => TaskEntityType.Imageflow,
                "knowledge" => TaskEntityType.Knowledge,
                "plugin" => TaskEntityType.Plugin,
                "prompt" => TaskEntityType.Prompt,
                "shortcut" => TaskEntityType.Shortcut,
                "trigger" => TaskEntityType.Trigger,
                "ui" => TaskEntityType.Ui,
                "variable" => TaskEntityType.Variable,
                "workflow" => TaskEntityType.Workflow,
                _ => null,
            };
        }
    }
}