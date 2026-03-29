//HintName: G.Models.TaskEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TaskEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="app")]
        App,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="database")]
        Database,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="imageflow")]
        Imageflow,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="knowledge")]
        Knowledge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="plugin")]
        Plugin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shortcut")]
        Shortcut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trigger")]
        Trigger,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ui")]
        Ui,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="variable")]
        Variable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow")]
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